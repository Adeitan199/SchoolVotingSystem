using SchoolVotingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class ElectionRepository
    {
        private readonly ApplicationContext Context;
        VoteRepository voterepo;
        public ElectionRepository(ApplicationContext context)
        {
            Context = context;
        }


        public void CreateElection()
        {
            ApplicationContext Context = new();
            AdminRepository adminrepo = new AdminRepository(Context);
            while (true)
            {
                Console.WriteLine("Enter Election Type");
                string electionName = Console.ReadLine();

                Console.WriteLine("Enter the commencement time");
                DateTime commence = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter the closing time");
                DateTime endtime = DateTime.Parse(Console.ReadLine());

                var election = new Election
                {
                    Name = electionName,
                    ElectionBegins = commence,
                    Electioncloses = endtime,
                };
                Context.Elections.Add(election);
                Context.SaveChanges();

                Console.WriteLine("Enter 1 to Register another election, 2 to Exit");
                int elect = int.Parse(Console.ReadLine());
                if (elect == 1)
                {
                    CreateElection();
                  
                }
                else
                {
                    break;
                }
            }
            
        }
        public void SelectElectionAndVote()
        {
            ApplicationContext Context = new();
            VoteRepository voterepo = new VoteRepository(Context);
     
            
                Console.WriteLine(":::::::::::::WELCOME TO THE STUDENT UNION ELECTION PORTAL:::::::::::::");
                voterepo.LoginToVote();
            

        }
    }
}
