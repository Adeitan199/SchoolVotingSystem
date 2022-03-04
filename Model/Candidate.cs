using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatricNumber { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public virtual List<Vote>Votes { get; set; }
          

    }
}
