using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
    public class Student:Person
    {
        public int Id { get; set; }
        public string MatricNumber { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }

        
    }
}
