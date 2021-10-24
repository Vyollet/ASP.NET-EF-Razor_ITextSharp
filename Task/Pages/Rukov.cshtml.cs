using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Task.Pages
{
    
    public class RukovModel : PageModel
    {
        private readonly DataContext _context;
        private readonly MvcOptions _mvcOptions;
        public RukovModel(DataContext context, IOptions<MvcOptions> mvcOptions)
        {
            _context = context;
            _mvcOptions = mvcOptions.Value;
        }
        
        public IList<DataEmployeeEffectiveness> Zadachi { get; set; }
        
        public async System.Threading.Tasks.Task OnGetAsync()
        {
                Zadachi = await _context.employeeEffectivenesses.Take(
                    _mvcOptions.MaxModelValidationErrors).ToListAsync();
        }
        
        
        public async System.Threading.Tasks.Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var zadacha = await _context.employeeEffectivenesses.FindAsync(id);

            if (zadacha != null)
            {
                _context.employeeEffectivenesses.Remove(zadacha);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
       
    }
}