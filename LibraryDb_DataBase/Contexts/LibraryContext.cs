using LibraryDb_Model.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryDb_DataBase.Contexts
{
    internal class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConStr = new ConfigurationManager()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection");

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);
        }

       

        public virtual DbSet<Author>? Authors { get; set; }
        public virtual DbSet<Book>? Books { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }

        public virtual DbSet<Student>? Students { get; set; }

        public virtual DbSet<T_Card>? T_Cards { get; set; }

        public virtual DbSet<S_Card>? S_Cards { get; set; }
        public virtual DbSet<Department>? Departments { get; set; }
        public virtual DbSet<Faculty>? Faculties { get; set; }

        public virtual DbSet<Group>? Groups { get; set; }
        public virtual DbSet<Lib>? Libs { get; set; }
        public virtual DbSet<Pres>? Preses  { get; set; }

        public virtual DbSet<Teacher>? Teachers { get; set; }

        public virtual DbSet<Theme>? Themes { get; set; }
    }
}
