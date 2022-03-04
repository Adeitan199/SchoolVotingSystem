using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
    public class Election
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ElectionBegins { get; set; }
        public DateTime Electioncloses { get; set; }
        public virtual List<Vote> Votes { get; set; }
    }
}
