using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Task.anketaCLasses
{
    public class employeeEffectivenesByManager : Controller
    {
        private static DataContext _context;

        public employeeEffectivenesByManager(DataContext context)
        {
            _context = context;
        }

        public static void Add(DataEmployeeEffectivenessByManager data)
        {
            var entity = _context.employeeEffectivenessByManager.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            
            string workload = "areaWorkload";
            string additionalProjects = "areaAdditionalProjects";
            string qualityExecution = "areaQualityExecution";
            string timeLineExecution = "areaTimeLineExecution";
            string evaluenceEffectivenes = "areaEvaluenceEffectivenes";

            DataEmployeeEffectivenessByManager data = new DataEmployeeEffectivenessByManager()
            {
                EmployeeEffectivenessByManagerID = 0,
                Workload = workload,
                AdditinalProjects = additionalProjects,
                QualityExecution = qualityExecution,
                TimelineExecution =  timeLineExecution,
                EvaluenceEffectivenes =  evaluenceEffectivenes
            };
            Add(data);
            
            return OnPost(name);
        }
    }
}