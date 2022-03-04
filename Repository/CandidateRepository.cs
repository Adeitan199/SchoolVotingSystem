using SchoolVotingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class CandidateRepository
    {
        private readonly ApplicationContext Context;

        AdminRepository adminrep;
        public CandidateRepository(ApplicationContext context)
        {
            Context = context;
        }

        public void RegisterCandidate()
        {
            ApplicationContext Context = new();
            AdminRepository adminrepo = new AdminRepository(Context);

            Console.WriteLine("Enter your Matric Number");
            string matricNum = Console.ReadLine();

            var candidate = StudentRepository.students.Where(x => x.MatricNumber == matricNum).SingleOrDefault();

            if (candidate != null && !Context.Voters.Any(s => s.MatricNumber == matricNum))
            {
                Console.WriteLine("Enter the id of the election you want to participate in");
                adminrepo.GetElections();
                int election = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the id of the position you want to contest in");
                adminrepo.GetAllPositions();
                int post = int.Parse(Console.ReadLine());

                var Candidate = new Candidate
                {
                    MatricNumber = candidate.MatricNumber,
                    ElectionId = election,
                    PositionId = post,
                    FirstName = candidate.FirstName,
                    LastName = candidate.LastName,
                };

                Context.Candidates.Add(Candidate);
                Context.SaveChanges();
                Console.WriteLine($"{candidate.FirstName} {candidate.LastName}, you have successfully registered  as a candidate in" +
                $" the 2022 Election");

            }
        
        }


        public int GetContestantForPost( int post)
        {
           
            var contestants = Context.Candidates.Where(x => x.PositionId == post);

            foreach (var item in contestants)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
            }
            return post;
        }

        public void UpdateCandidate()
        {

            Console.WriteLine("Enter your matric number");
            string matNum = Console.ReadLine();

            var candidate = Context.Candidates.Where(x => x.MatricNumber == matNum).SingleOrDefault();
            if (candidate != null)
            {
                Console.WriteLine("Enter election Id");
                int newElection = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter position Id");
                int newposition = int.Parse(Console.ReadLine());

                candidate.ElectionId = newElection;
                candidate.PositionId = newposition;

                Context.Update(candidate);
                Context.SaveChanges();
                Console.WriteLine("You have sucessfully updated your record");
            }
            else
            {
                Console.WriteLine("You have either entered a wrong matric number or you have not registered as a candidate");
                Console.WriteLine("Enter 1 to try again, 2 to register");
                int updateOrReg = int.Parse(Console.ReadLine());
                
                if (updateOrReg == 1)
                {
                    UpdateCandidate();
                }
                else
                {
                    RegisterCandidate();
                }
              
            }
        }
    }
}
