using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Task.anketaCLasses
{
    public class individualEmployeeDevelopment : Controller
    {
        private static DataContext _context;

        public individualEmployeeDevelopment(DataContext context)
        {
            _context = context;
        }

        public static void Add(DataIndividualEmployeeDevelopment data)
        {
            var entity = _context.individualEmployeeDevelopment.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string developmentObjective = "areaDevelopmentObjective";
            string methodDevelopment = "areaDevelopmentObjective";
            string responsible = "areaMethodDevelopment";
            string dateStart = "areaDateStart";
            string dateEnd = "areaDateEnd";


            DataIndividualEmployeeDevelopment data = new DataIndividualEmployeeDevelopment()
            {
                IndividualEmployeeDevelopmentID = 0,
                DevelopmentObjective = developmentObjective,
                MethodDevelopment = methodDevelopment,
                Responsible = responsible,
                
                DateStart = dateStart,
                DateEnd = dateEnd
            }; 
            Add(data);
            return OnPost(name);
        }
    }
}