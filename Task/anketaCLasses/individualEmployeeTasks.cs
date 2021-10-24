using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using Task.Pages;

namespace Task.anketaCLasses
{
    public class individualEmployeeTasks : Controller
    {
        private static DataContext _context;

        public individualEmployeeTasks(DataContext context)
        {
            _context = context;
        }

        public static void Add(DataIndividualEmployeeTasks data)
        {
            var entity = _context.individualemployeetasks.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string zadacha = "areaZadacha";
            string keyResult = "areaKeyResult";
            string timelineExecution = "areaTimelineExecution";
            string comment = "areaComment";


            DataIndividualEmployeeTasks data = new DataIndividualEmployeeTasks()
            {
                IndividualEmployeeTasksID = 0,
                Zadacha = zadacha,
                KeyResult = keyResult,
                TimelineExecution = timelineExecution,
                Comment = comment

            };
            Add(data);
            return OnPost(name);
        }
    }
}