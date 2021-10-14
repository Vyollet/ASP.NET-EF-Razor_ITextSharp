using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Task.Pages
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
    public class IndexModel : PageModel
    {
       
        public void OnGet()
        {

        }
        
        public IActionResult OnPost([FromForm]string name)
        {

            PDFedit.EdiiText();
            /*string dat1 = Request.Form["textarea1"];
            string dat2 = Request.Form["textarea2"];
            string dat3 = Request.Form["textarea3"];
            string dat4 = Request.Form["textarea4"];
            string dat5 = Request.Form["textarea5"];
            string dat6 = Request.Form["textarea6"];
            string dat7 = Request.Form["textarea7"];
            
//            string dat7 = Request.Form["textarea7"]; stop
            
            

            Data data = new Data()
            {
                Id = 0,
                Zadacha1 = dat1,
                Zadacha2 = dat2,
                Zadacha3 = dat3,
                Zadacha4 = dat4,
                Zadacha5 = dat5,
                Zadacha6 = dat6,
                Zadacha7 = dat7
            };

            AnketaSotrudnik.Add(data);
            return RedirectToAction("ButtonClick");*/
            return RedirectToAction("ButtonClick");
        }
    }
}
