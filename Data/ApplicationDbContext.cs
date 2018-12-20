using System.Data.Entity;
using System.Diagnostics;
using Data.Entities;

namespace Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }

        public ApplicationDbContext()
        {
            Database.Log = sql => Debug.Write(sql);
        }
    }
}
