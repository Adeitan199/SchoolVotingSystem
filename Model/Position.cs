using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElectionId {get; set;}
        public Election Election { get; set; }

    }
}
