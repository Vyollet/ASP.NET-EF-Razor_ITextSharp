using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Task.Pages
{
    public class SotrModel : PageModel
    {
        public void OnGet()
        {
        }
        private static DataContext _context;
        private readonly MvcOptions _mvcOptions;

        public SotrModel(DataContext context, IOptions<MvcOptions> mvcOptions)
        {
            _context = context;
            _mvcOptions = mvcOptions.Value;
        }
        
        public static void Add(DataEmployeeEffectiveness data)
        {
            var entity = _context.employeeEffectivenesses.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string dataZadacha1 = Request.Form["areaZadacha"];
            //string dataZadacha2 = Request.Form["textarea2"];
            //string dataZadacha3 = Request.Form["textarea3"];

            DataEmployeeEffectiveness data = new DataEmployeeEffectiveness
            {
                EmployeeEffectivenessID = 0,
                Zadacha = dataZadacha1
            };
            
            Add(data);

            //
            //Выгрузка в pdf
            //
            string sourceFile = @"..\\Doc.pdf";
            string descFile = @"..\\DocItext.pdf";
            PDFedit pdfEnd = new PDFedit();
            pdfEnd.ReplaceTextInPDF(sourceFile, descFile, "",dataZadacha1);
            //

            
            return RedirectToAction("ButtonClick");
        }
    }
}