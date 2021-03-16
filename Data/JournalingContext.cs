using Journaling.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journaling.Data
{
    public class JournalingContext : DbContext
    {
        public JournalingContext(DbContextOptions<JournalingContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().ToTable("Question");
        }
    }
}
