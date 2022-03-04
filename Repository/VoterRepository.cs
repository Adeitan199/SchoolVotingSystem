using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolVotingSystem.Model;

namespace SchoolVotingSystem.Repository
{
    class VoterRepository
    {
        private readonly ApplicationContext Context;

        public VoterRepository(ApplicationContext context)
        {
            Context = context;
        }



        public void RegisterVoter()
        {
            Console.WriteLine("Enter your matric number");
            string matricNum = Console.ReadLine();

            var student = StudentRepository.students.Where(x => x.MatricNumber == matricNum).SingleOrDefault();

            if (student != null && !Context.Voters.Any(s => s.MatricNumber == matricNum))
            {
                
                string voterId = VoterRegistrationNum();

                var voter = new Voter
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    VoterRegNum = voterId,
                    MatricNumber = matricNum,
                };

                Context.Voters.Add(voter);
                Context.SaveChanges();
                Console.WriteLine($"{student.FirstName} {student.LastName}, you have successfully registered as a voter, your voter's registration numbers is {voterId}");

            }
            else
            {
                Console.WriteLine("You have entered and invalid Matric Number or you have already registered as a voter");
            }
        }

        public string VoterRegistrationNum()
        {
            return $"Vot/{Guid.NewGuid().ToString().Substring(0, 4)}";
        }


        public void UpdateVoter()
        {
            Console.WriteLine("Enter the your voter registration number");
            string regNum = Console.ReadLine();

            var id = Context.Voters.Where(x => x.VoterRegNum == regNum).SingleOrDefault();

            if (id != null)
            {
                Console.WriteLine("Enter your Email Address");
                string emailAdd = Console.ReadLine();

                Console.WriteLine("Enter your Phone Number");
                string phoneNum = Console.ReadLine();
   
                Context.Voters.Update(id);
                Context.SaveChanges();
                Console.WriteLine("You have successfully updated your record");
            }
            else
            {
                Console.WriteLine("You have entered an invalid voter registration number");
            }
           
        }
    }
}
