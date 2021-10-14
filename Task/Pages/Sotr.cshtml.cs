using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


            string dat1 = Request.Form["textarea1"];
            string dat2 = Request.Form["textarea2"];
            /*string dat3 = Request.Form["textarea3"];
            string dat4 = Request.Form["textarea4"];
            string dat5 = Request.Form["textarea5"];
            string dat6 = Request.Form["textarea6"];
            string dat7 = Request.Form["textarea7"];*/



            Data data = new Data()
            {
                Id = 0,
                Zadacha1 = dat1,
                Zadacha2 = dat2,
                /*Zadacha3 = dat3,
                Zadacha4 = dat4,
                Zadacha5 = dat5,
                Zadacha6 = dat6,
                Zadacha7 = dat7*/
            };

            AnketaSotrudnik.Add(data);
            PDFedit.EdiiText();
            return RedirectToAction("ButtonClick");
        }
    }
}