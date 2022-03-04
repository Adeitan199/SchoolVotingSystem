using SchoolVotingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class AdminRepository
    {
        private readonly ApplicationContext Context;
        ElectionRepository electionrepo;

        public AdminRepository(ApplicationContext context)
        {
            Context = context;
        }


        public void CreateAdmin()
        {
            try
            {
                /*Console.WriteLine("Enter your level");
                string level = Console.ReadLine();
                var lev = StudentRepository.students.Where(x => x.Level == level);
                if (level != "500L" && level != "400L")
                {
                    Console.WriteLine("You are not eligible to register as an Admin for this election");
                }
                else*/
                {
                    Console.WriteLine("Enter your Matric Number");
                    string MatNum = Console.ReadLine();

                    var matricNum = StudentRepository.students.Where(x => x.MatricNumber == MatNum).SingleOrDefault();

                    if (matricNum != null)
                    {
                        Console.WriteLine("::::::::::::::Welcome to the 2022 Election Admin Portal::::::::::::");

                        Console.WriteLine("Enter your post");
                        string post = Console.ReadLine();

                        var pass = GenerateAdminPass();

                        var admin = new Admin
                        {
                            FirstName = matricNum.FirstName,
                            LastName = matricNum.LastName,
                            Password = pass,
                            Post = post,
                        };
                        Context.Admins.Add(admin);
                        Context.SaveChanges();
                        Console.WriteLine($"You have successfully registered as an admin for the post of {post}. Your Admin password is {pass}");
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid Matric Number");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GenerateAdminPass()
        {
            return $"Admin/{Guid.NewGuid().ToString().Substring(0, 3)}";
        }


        public void AdminLogin()
        {
            Console.WriteLine("Enter your Admin Password");
            string pass = Console.ReadLine();

            var password = Context.Admins.Where(x => x.Password == pass).SingleOrDefault();

            while (true)
            {
                if (password != null)
                {
                    Console.WriteLine(":::::::::::::::::Welcome to the 2022 Eletion Admin Portal:::::::::::::::::");
                    Console.WriteLine("Enter 1 to create election, 2 to create Position 3 to register another admin, 4 to go back to menu or exit");
                    int admin = int.Parse(Console.ReadLine());

                    if (admin == 1)
                    {
                        RegisterElection();
                    }
                    else if (admin == 2)
                    {
                        CreatePositons();
                    }
                    else if (admin == 3)
                    {
                        CreateAdmin();
                    }
                    else
                    {
                        Console.WriteLine("Enter 1 to go back to main menu, 2 to exit");
                        int menu = int.Parse(Console.ReadLine());

                        if (menu == 1)
                        {
                            AdminLogin();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            
        }

        public void CreatePositons()
        {   
                while (true)
                {
                    Console.WriteLine("::::::::Welcome to the 2022 Election Position Page:::::::::: ");

                Console.WriteLine("Enter the election id");
                int election = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter position");
                    string post = Console.ReadLine();

                var position = new Position
                {
                    Name = post,
                    ElectionId = election,
                    };
                    Context.Positions.Add(position);
                    Context.SaveChanges();
                    Console.WriteLine($"You have successfulyy created the {post} position in this election");

                    Console.WriteLine("Enter 1 to Create another position, 2 to Exit");
                    int ent = int.Parse(Console.ReadLine());

                    if (ent == 1)
                    {
                        CreatePositons();
                    }
                    else if(ent == 2)
                    {
                        break;
                    }

                break;
                }
        }
        public void GetAllPositions()
        {

            var position = from x in Context.Positions select x;

            foreach (var item in position)
            {
                Console.WriteLine($"{item.Id}==> {item.Name}");
            }
        }

        public void RegisterElection()
        {
            ApplicationContext Context = new();
            ElectionRepository electionrepo = new ElectionRepository(Context);
   
            electionrepo.CreateElection();
        }

        public void GetElections()
        {
            var selectedElection = from x in Context.Elections select x;

            foreach (var item in selectedElection)
            {
                Console.WriteLine($"{ item.Id} { item.Name}");
            }
        }
    }
}
