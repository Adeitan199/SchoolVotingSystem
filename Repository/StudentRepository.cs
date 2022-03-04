using SchoolVotingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class StudentRepository
    {
        public static List<Student> students = new List<Student>() 
        {
            new Student
            {
                Id = 1,
                FirstName = "Adesale",
                LastName = "Ola",
                MatricNumber = "STU001",
                Department =  "SLT",
                Level = "400L"           
            },
            new Student
            {
                 Id = 2,
                FirstName = "Adeola",
                LastName = "Olu",
                MatricNumber = "STU002",
                Department =  "Computer Science",
                Level = "400L"
            },
            new Student
            {
                 Id = 3,
                FirstName = "Adewole",
                LastName = "Akin",
                MatricNumber = "STU003",
                Department =  "MicroBiology",
                Level = "100L"
            },
            new Student
            {
                 Id = 4,
                FirstName = "Akinola",
                LastName = "Jelil",
                MatricNumber = "STU004",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 5,
                FirstName = "Salaudeen",
                LastName = "Haleem",
                MatricNumber = "STU005",
                Department =  "English",
                Level = "400L"
            },
            new Student
            {
                 Id = 6,
                FirstName = "Ajibike",
                LastName = "Qamar",
                MatricNumber = "STU006",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 7,
                FirstName = "Johnson",
                LastName = "John",
                MatricNumber = "STU007",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 8,
                FirstName = "Emmanuel",
                LastName = "Femi",
                MatricNumber = "STU008",
                Department =  "Civil Engineering",
                Level = "200L"
            },
            new Student
            {
                 Id = 9,
                FirstName = "Adeola",
                LastName = "Mary",
                MatricNumber = "STU009",
                Department =  "Agric Economics",
                Level = "300L"
            },

            new Student
            {
                 Id = 10,
                FirstName = "Adeola",
                LastName = "Olu",
                MatricNumber = "STU010",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 11,
                FirstName = "Falola",
                LastName = "John",
                MatricNumber = "STU011",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 12,
                FirstName = "Aina",
                LastName = "Femi",
                MatricNumber = "STU012",
                Department =  "Computer Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 13,
                FirstName = "Ajala",
                LastName = "Kemi",
                MatricNumber = "STU013",
                Department =  "Sociology",
                Level = "300L"
            },
            new Student
            {
                 Id = 14,
                FirstName = "Ajayi",
                LastName = "Femi",
                MatricNumber = "STU014",
                Department =  "Political Science",
                Level = "300L"
            },

            new Student
            {
                 Id = 15,
                FirstName = "Ajayi",
                LastName = "Kola",
                MatricNumber = "STU015",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 16,
                FirstName = "Akinwale",
                LastName = "Femi",
                MatricNumber = "STU016",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 17,
                FirstName = "Olalomi",
                LastName = "Ayinde",
                MatricNumber = "STU017",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 18,
                FirstName = "Akinfemi",
                LastName = "Babatunde",
                MatricNumber = "STU018",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 19,
                FirstName = "Ajayi",
                LastName = "Nifemi",
                MatricNumber = "STU019",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 20,
                FirstName = "Babafemi",
                LastName = "Abiola",
                MatricNumber = "STU020",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 21,
                FirstName = "Obalola",
                LastName = "Abiola",
                MatricNumber = "STU0201",
                Department =  "Political Science",
                Level = "400L"
            },
            new Student
            {
                 Id = 22,
                FirstName = "Babafemi",
                LastName = "Obalolu",
                MatricNumber = "STU022",
                Department =  "Political Science",
                Level = "400L"
            },
            new Student
            {
                 Id = 23,
                FirstName = "Adewale",
                LastName = "Abiola",
                MatricNumber = "STU023",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 24,
                FirstName = "Olufemi",
                LastName = "Abiola",
                MatricNumber = "STU024",
                Department =  "Political Science",
                Level = "300L"
            },
            new Student
            {
                 Id = 25,
                FirstName = "Babafemi",
                LastName = "Ola",
                MatricNumber = "STU025",
                Department =  "Psychology",
                Level = "300L"
            },
            new Student
            {
                 Id = 26,
                FirstName = "Babafemi",
                LastName = "Abidemi",
                MatricNumber = "STU026",
                Department =  "Law",
                Level = "400L"
            },
            new Student
            {
                 Id = 27,
                FirstName = "Kolawole",
                LastName = "Balogun",
                MatricNumber = "STU027",
                Department =  "Physics",
                Level = "400L"
            },
            new Student
            {
                 Id = 28,
                FirstName = "Kamar",
                LastName = "Nasir",
                MatricNumber = "STU028",
                Department =  "Agric Economics",
                Level = "500L"
            },
            new Student
            {
                 Id = 29,
                FirstName = "Babajide",
                LastName = "Abiola",
                MatricNumber = "STU029",
                Department =  "Biology",
                Level = "300L"
            },
            new Student
            {
                 Id = 30,
                FirstName = "Folorunsho",
                LastName = "Abiola",
                MatricNumber = "STU030",
                Department =  "Civil Engineering",
                Level = "300L"
            },
            new Student
            {
                 Id = 31,
                FirstName = "Babajide",
                LastName = "Abiola",
                MatricNumber = "STU031",
                Department =  "Engish",
                Level = "400L"
            },
            new Student
            {
                 Id = 32,
                FirstName = "Ayinde",
                LastName = "Kemisola",
                MatricNumber = "STU032",
                Department =  "History",
                Level = "400L"
            },
















        };



        /*public void RegisterStudent()
        {
            Console.WriteLine("Enter your firstname");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your lastname");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your MatricNumber again");
            string matNum = Console.ReadLine();

            Console.WriteLine("Enter your Department");
            string dept = Console.ReadLine();

            Console.WriteLine("Enter your Email Address");
            string emailAdd = Console.ReadLine();

            Console.WriteLine("Enter your Phone Number");
            string phoneNum = Console.ReadLine();

            Console.WriteLine("Enter your level");
            int level = int.Parse(Console.ReadLine());

            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                MatricNumber = matNum,
                Department = dept,
                EmailAddress = emailAdd,
                PhoneNumber = phoneNum,
                Level = level,
            };
            Context.Students.Add(student);
            Context.SaveChanges();
            Console.WriteLine($"{firstName}, your student record is created successfully");
        }*/
    }
}
