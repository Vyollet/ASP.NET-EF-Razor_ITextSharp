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

            var dataC1 = data.Zadacha1.Remove(dataZ1.IndexOf(','), dataZ1.Length - dataZ1.IndexOf(','));
            

            string sourceFile = @"..\\Doc.pdf";
            string descFile = @"..\\DocItext.pdf";
            PDFedit pdfObj = new PDFedit();
            pdfObj.ReplaceTextInPDF(sourceFile, descFile, "<",dataZ1);
            //pdfObj.ReplaceTextInPDF(tempSource, descFile, ">",dataC1);

            return RedirectToAction("ButtonClick");
        }
    }
}