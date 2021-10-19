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

        [BindProperty]
        public Data zadachi { get; set; }

        public IList<Data> Zadachi { get; set; }
        public async System.Threading.Tasks.Task OnGetAsync()
        {
              
            {
                /*
                Zadachi = await _context.OpisanieZadach
                    .Include(c => c.Id)
                    .AsNoTracking()
                    .ToListAsync();
                    */
                
                
                Zadachi = await _context.OpisanieZadach.Take(
                    _mvcOptions.MaxModelValidationErrors).ToListAsync();
            }

        }

    }


    /*public List<Data> GetAllUsers()
    {
        List<Data> ZadachiList = null;

        using (DataTable table = SqlDBHelper.ExecuteSelectCommand("GetAllUsers", CommandType.StoredProcedure))
        {
            if (table.Rows.Count > 0)
            {
                ZadachiList = new List<Data>();

                foreach (DataRow row in table.Rows)
                {
                    Data data = new Data();

                    data.Id = (int) table.Rows[0]["Id"];
                    data.Zadacha1 = table.Rows[0]["Pass"].ToString();
                    data.Zadacha2 = table.Rows[0]["Name"].ToString();

                    ZadachiList.Add(data);
                }
            }
        }

        return ZadachiList;
    }*/

}