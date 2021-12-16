using DigitalViagem.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalViagem.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=David; Initial Catalog=CRUDVIAGEM; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table => { 
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);
                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Data_Nascimento).HasColumnType("date");
                table.Property(prop => prop.Telefone).HasColumnType("char(15)").IsRequired();
                table.Property(prop => prop.Endereco).HasColumnType("char(50)").IsRequired();
                table.Property(prop => prop.Situacao).HasConversion<string>(); 
            });
        }
    }
}
