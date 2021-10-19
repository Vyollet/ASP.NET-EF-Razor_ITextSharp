using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Task
{
    public class DataContext : DbContext
    {
        /*
        protected void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=BD.db");
            */

        public DbSet<Data> OpisanieZadach { get; set; }
        
        public DataContext(DbContextOptions options) 
            : base(options) {
        }

 

    }

    public class Data
    {
        [Key] public int Id { get; set; } 
        [Required]
        public string Zadacha1 { get; set; } 
        public string Zadacha2 { get; set; }
        /*public string Zadacha3 { get; set; }
        public string Zadacha4 { get; set; }
        public string Zadacha5 { get; set; }
        public string Zadacha6 { get; set; }
        public string Zadacha7 { get; set; }*/

    }
    
}
