using SchoolVotingSystem.Menu;
using SchoolVotingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class VoteRepository
    {
        private readonly ApplicationContext Context;
        CandidateRepository candidaterep;

        public VoteRepository(ApplicationContext context)
        {
            Context = context;
        }


        public void LoginToVote()
        {
            ApplicationContext Context = new();
            AdminRepository adminrepos = new AdminRepository(Context);
            CandidateRepository candidaterepo = new CandidateRepository(Context);
            MainMenu mainmenu = new MainMenu(Context);

            Console.WriteLine(":::::::::::WELCOME TO THE 2022 ELECTION PORTAL:::::::::::::");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the Election Id");
            adminrepos.GetElections();
            int election = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("View all positions available for the election");
            adminrepos.GetAllPositions();

            Console.WriteLine("Enter the id of the position");
            int post = int.Parse(Console.ReadLine());
            var position = Context.Positions.Where(x => x.Id == post).SingleOrDefault();

            Console.WriteLine("Enter your voter registration number");
            string regNum = Console.ReadLine();
            var verifyVoter = from x in Context.Votes where x.PositionId == post select x.VoterRegNum;
            var voter = Context.Voters.Where(x => x.VoterRegNum == regNum).SingleOrDefault();

            

            if (voter != null && !Context.Votes.Any(s => s.VoterRegNum == regNum) && verifyVoter==null)
            {
                Console.WriteLine("You have successfully login to participate in the election");
                Console.WriteLine(" ");

                if (position != null)
                {
                    candidaterepo.GetContestantForPost(post);   
                    Console.WriteLine($"Enter the id of your prefered Candidate for the post of {position.Name}");
                    int candidate = int.Parse(Console.ReadLine());
                    

                    var Vote = new Vote
                    {
                        ElectionId = election,
                        VoterRegNum = voter.VoterRegNum,
                        PositionId=post,
                        CandidateId=candidate,
                    };
                    Context.Votes.Add(Vote);
                    Context.SaveChanges();
                    Console.WriteLine($"You have successfully cast your vote for the position of {position.Name}");
                }
                else
                {
                    Console.WriteLine("The position you entered does not exist");
                }

                Console.WriteLine("Enter 1 to cast your vote for another position");
                int cast = int.Parse(Console.ReadLine());
                if (cast == 1)
                {
                    LoginToVote();
                }
                else if (cast == 2)
                {
                    mainmenu.Election();
                }

            }
            else
            {
                Console.WriteLine("You have already participated in the election for this position");
            }
        }

        public void GetResult()
        {
            Console.WriteLine("Enter the Id of the position you want to view the result");
            int position = int.Parse(Console.ReadLine());
            var result = Context.Votes.Where(x => x.PositionId == position).Count();
            var results= from x in Context.Votes orderby x.CandidateId where x.PositionId==position select x;
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Candidate.FirstName} {item.CandidateId}");
            }
        }
    }
}

