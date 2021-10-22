namespace Task.anketaCLasses
{
    public class individualEmployeeTasks
    {
        private static DataContext _context;

        public *(DataContext context)
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
            string zadacha = Request.Form["areaZadacha"];
            string keyResult = Request.Form["areaKeyResult"];
            string timelineExecution = Request.Form["areaTimelineExecution"];
            string comment = Request.Form["areaComment"];


            DataIndividualEmployeeTasks data = new DataIndividualEmployeeTasks()
            {
                IndividualEmployeeTasksID = 0,
                Zadacha = zadacha,
                KeyResult = keyResult,
                TimelineExecution = timelineExecution,
                Comment = comment

            };
        }
    }
}