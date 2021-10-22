namespace Task.anketaCLasses
{
    public class employeeEffectivenesByManager
    {
        private static DataContext _context;

        public *(DataContext context)
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
            string workload = Request.Form["areaWorkload"];
            string additionalProjects = Request.Form["areaAdditionalProjects"];
            string qualityExecution = Request.Form["areaQualityExecution"];
            string timeLineExecution = Request.Form["areaTimeLineExecution"];
            string evaluenceEffectivenes = Request.Form["areaEvaluenceEffectivenes"];

            DataEmployeeEffectivenessByManager data = new DataEmployeeEffectivenessByManager()
            {
                EmployeeEffectivenessByManagerID = 0,
                Workload = workload,
                AdditinalProjects = additionalProjects,
                QualityExecution = qualityExecution,
                TimelineExecution =  timeLineExecution,
                EvaluenceEffectivenes =  evaluenceEffectivenes
            };
        }
    }
}