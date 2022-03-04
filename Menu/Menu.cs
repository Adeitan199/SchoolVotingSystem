using SchoolVotingSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Menu
{
    class MainMenu
    {
         ApplicationContext Context = new();

        public MainMenu(ApplicationContext context)
        {
            Context = context;
        }

        StudentRepository studentrepo;
        
        
        internal StudentRepository Studentrepo { get => studentrepo; set => studentrepo = value; }


        public void Election()
        {
            Console.WriteLine("::::::::::::WELCOME TO THE ELECTION PORTAL::::::::::::::::");
            Console.WriteLine(" ");
            Console.WriteLine($"Enter 1 to Sign up");
            Console.WriteLine("Enter 2 to Sign-in into the election Portal");
            Console.WriteLine("Enter 3 to view election results");
            Console.WriteLine("Enter 4 to Exit");
            int sign = int.Parse(Console.ReadLine());

            while (true)
            {
                if (sign == 1)
                {
                    Voter();

                    Console.WriteLine("Enter 1 to proceed to the sign in page, 2 to exit");
                    int proceed = int.Parse(Console.ReadLine());
                    if (proceed == 1)
                    {
                        Console.WriteLine("Enter 1 to register as Candidate");
                        Console.WriteLine("Enter 2 to sign in to the election page");
                        int signin = int.Parse(Console.ReadLine());

                        if (signin == 1)
                        {
                            Candidate();
                        }
                        else if (signin == 2)
                        {
                            Vote();
                        }
                    }
                }
                else if (sign == 2)
                {
                    Console.WriteLine("Enter 1 to register as candidate");
                    Console.WriteLine("Enter 2 to vote");
                    int register = int.Parse(Console.ReadLine());

                    if (register == 1)
                    {
                        Candidate();
                    }
                    else if (register == 2)
                    {
                        Vote();
                    }

                }
                else if (sign == 3)
                {
                    Result();
                }
                else if (sign == 4)
                {
                    Console.WriteLine("Thank you for visiting the election portal");
                    break;
                }
            }
            
        }

        public void RegisterStudents() 
        {
            ApplicationContext Context = new();
            //StudentRepository studentrepo = new StudentRepository(Context);
            Console.WriteLine("Enter 1 to register student 2 to exit");
            int stu = int.Parse(Console.ReadLine());

            while (true)
            {
                if (stu == 1)
                {
                   // studentrepo.RegisterStudent();
                    Console.WriteLine("Press any key to exit");
                    break;
                }
                else
                {
                    break;
                }
            }
        }


        public void Admin()
        {
            ApplicationContext Context = new();
            AdminRepository adminrepo = new AdminRepository(Context);

            Console.WriteLine("Enter 1 to register as Admin 2 to login, 3 to Exit");
            int ad = int.Parse(Console.ReadLine());

            while (true)
            {
                if (ad == 1)
                {
                    adminrepo.CreateAdmin();
                    break;

                }
                else if(ad==2)
                {
                    adminrepo.AdminLogin();
                    break;
                }
                else
                {
                    break;
                }

            }
            
        }

        public void Voter()
        {

            ApplicationContext Context = new();
            VoterRepository voterrepo = new VoterRepository(Context);
            Console.WriteLine("Enter 1 to register, 2 to update record, 3 to exit");
            int log = int.Parse(Console.ReadLine());

            
            
                if (log == 1)
                {
                    voterrepo.RegisterVoter();
                }
                else if (log == 2)
                {
                    voterrepo.UpdateVoter();
                }
                else
                {
                    
                }
                
            
            
        }
        public void Candidate()
        {
            ApplicationContext Context = new();
            CandidateRepository candidaterepo = new CandidateRepository(Context);

            Console.WriteLine("*************WELCOME TO THE 2022 ELECTION CANDIDATE PORTAL******************");
            Console.WriteLine("Enter 1 to register, Enter 2 to exit");
            int reg = int.Parse(Console.ReadLine());

            
            
                if (reg == 1)
                {
                    Console.WriteLine("Enter 1 to get list of all positions and register, 2 to exit");
                    int cand = int.Parse(Console.ReadLine());

                    while (true)
                    {
                        if (cand == 1)
                        {
                            candidaterepo.RegisterCandidate();
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    
                }
                
            
        }
        public void Vote()
        {
            ApplicationContext Context = new();
            ElectionRepository electionrepo = new ElectionRepository(Context);
            VoteRepository voterepo = new VoteRepository(Context);
            Console.WriteLine("::::::::::::::::WELCOME TO THE ELECTION PORTAL:::::::::::::::::::");


            voterepo.LoginToVote();

            // electionrepo.SelectElectionAndVote();
                

        }
        public void Result()
        {
            ApplicationContext Context = new();
            VoteRepository voterepo = new VoteRepository(Context);

            voterepo.GetResult();
        }
    }
}
