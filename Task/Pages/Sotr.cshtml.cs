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


            string dataZadacha1 = Request.Form["textarea1"];
            string dataZadacha2 = Request.Form["textarea2"];

            Data data = new Data()
            {
                Id = 0,
                Zadacha1 = dataZadacha1,
                Zadacha2 = dataZadacha2,
            };
            
            AnketaSotrudnik.Add(data);
            
            var dataC1 = dataZadacha1.Substring(dataZadacha1.IndexOf(',')+1);
            
            dataZadacha1 = dataZadacha1.Substring(0, dataZadacha1.IndexOf(','));
            

            string sourceFile = @"..\\Doc.pdf";
            string descFile = @"..\\DocItext.pdf";
            PDFedit pdfEnd = new PDFedit();
            pdfEnd.ReplaceTextInPDF(sourceFile, descFile, "<",dataZadacha1);
            
            //StartTemp
            if (dataC1 != null) 
            {
                string output = @"..\\DocItextFinal.pdf"; //change
                pdfEnd.ReplaceTextInPDF(descFile, output, ">",dataC1);
            }
            //EndTemp

            return RedirectToAction("ButtonClick");
        }
    }
}