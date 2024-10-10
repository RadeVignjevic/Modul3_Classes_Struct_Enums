namespace Modul3_Classes_Struct_Enums.DBContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using Modul3_Classes_Struct_Enums.Models;
    using Modul3_Classes_Struct_Enums.Models.DboModels;

    public class AddAppContext : DbContext
    {
        public DbSet<DboUser> DboUser { get; set; }
        public DbSet<DboPost> DboPost { get; set; }

        /// <summary>
        /// Configure connection string
        /// </summary>
        /// <param name="dbContextOptionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyAppDb;Trusted_Connection=True;");
        }

        /// <summary>
        /// Use to create indexes, releations, foreign keys
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
