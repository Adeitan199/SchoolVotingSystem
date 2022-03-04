using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
   public class Voter:Person
    {
        public int  Id { get; set; }
        public string VoterRegNum { get; set; }
        public string MatricNumber{ get; set; }
       

    }
}
