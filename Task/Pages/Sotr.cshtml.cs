using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Task.Pages
{
    public class SotrModel : PageModel
    {
        public void OnGet()
        {
        }
        private static DataContext _context;

        public SotrModel(DataContext context)
        {
            _context = context;
        }
        
        public static void Add(Data data)
        {
            var entity = _context.OpisanieZadach.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string dataZadacha1 = Request.Form["textarea1"];
            string dataZadacha2 = Request.Form["textarea2"];
            //string dataZadacha3 = Request.Form["textarea3"];

            Data data = new Data()
            {
                Id = 0,
                Zadacha1 = dataZadacha1,
                Zadacha2 = dataZadacha2,
            };
            
            Add(data);

            //
            //Выгрузка в pdf
            //
            /*string sourceFile = @"..\\Doc.pdf";
            string descFile = @"..\\DocItext.pdf";
            PDFedit pdfEnd = new PDFedit();
            pdfEnd.ReplaceTextInPDF(sourceFile, descFile, "",dataZadacha1);*/
            //

            
            return RedirectToAction("ButtonClick");
        }
    }
}