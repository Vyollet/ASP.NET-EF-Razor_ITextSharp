using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public int Id { get; set; }
        public string Zadacha1 { get; set; }
        public string Zadacha2 { get; set; }
        public string Zadacha3 { get; set; }
        public string Zadacha4 { get; set; }
        public string Zadacha5 { get; set; }
        public string Zadacha6 { get; set; }
        public string Zadacha7 { get; set; }

    }
}
