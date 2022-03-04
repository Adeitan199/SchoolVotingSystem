using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolVotingSystem.Repository
{
    class PositionRepository
    {
        private readonly ApplicationContext Context;

        public PositionRepository(ApplicationContext context)
        {
            Context = context;
        }
    }
}
