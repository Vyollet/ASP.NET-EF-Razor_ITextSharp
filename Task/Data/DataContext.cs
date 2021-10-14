using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Task
{
    public class DataContext : DbContext
    {

        public DbSet<Data> OpisanieZadach { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=..\\BD.db");
        }       
    }

    public class Data
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Zadacha1 { get; set; }
        public string Zadacha2 { get; set; }
        public string Zadacha3 { get; set; }
        public string Zadacha4 { get; set; }
        public string Zadacha5 { get; set; }
        public string Zadacha6 { get; set; }
        public string Zadacha7 { get; set; }

    }
}
