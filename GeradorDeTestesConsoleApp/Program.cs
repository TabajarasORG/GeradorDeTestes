using GeradorDeTestes.ModuloDisciplina;
using Microsoft.EntityFrameworkCore;

namespace GeradorDeTestesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            GeradorTesteDbContext dbContext = new();

            var disciplina = new Disciplina { Nome = "test"};
            dbContext.Add(disciplina);
            dbContext.SaveChanges();
        }
    }

   public class GeradorTesteDbContext : DbContext
    {
        public DbSet<Disciplina> Disciplinas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTestes;Integrated Security=True;Pooling=False";

            optionsBuilder.UseSqlServer(connectionString);

            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disciplina>(disciplinaBuilder =>
            {
                disciplinaBuilder.ToTable("TBDisciplina");

                disciplinaBuilder.Property(d => d.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                disciplinaBuilder.Property(d => d.Nome)
                .IsRequired()
                .HasColumnType("vachar(150)");
            });
        }
    }
}
