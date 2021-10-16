using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task.Pages
{
    public class SotrModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost([FromForm] string name)
        {


            string dataZ1 = Request.Form["textarea1"];
            string dataZ2 = Request.Form["textarea2"];

            Data data = new Data()
            {
                Id = 0,
                Zadacha1 = dataZ1,
                Zadacha2 = dataZ2,
            };
            
            var dataC1 = dataZ1.Substring(dataZ1.IndexOf(',')+1);
            
            dataZ1 = dataZ1.Substring(0, dataZ1.IndexOf(','));
            

            string sourceFile = @"..\\Doc.pdf";
            string descFile = @"..\\DocItext.pdf";
            PDFedit pdfEnd = new PDFedit();
            pdfEnd.ReplaceTextInPDF(sourceFile, descFile, "<",dataZ1);
            
            //StartTemp
            if (dataC1 != null) 
            {
                string output = @"..\\DocItextFinal.pdf";
                pdfEnd.ReplaceTextInPDF(descFile, output, ">",dataC1);
            }
            //EndTemp

            return RedirectToAction("ButtonClick");
        }
    }
}