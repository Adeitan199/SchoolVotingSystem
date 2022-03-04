using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Model
{
    public class Vote
    {
        public int Id { get; set; }
        public string VoterRegNum { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
    }
}
