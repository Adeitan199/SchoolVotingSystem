using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolVotingSystem.Model;

namespace SchoolVotingSystem
{
    class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SchoolVotingSystem;user=root;password=@Adeniyi199");
        }


       public DbSet<Voter> Voters { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Election> Elections { get; set; }
    }
}
