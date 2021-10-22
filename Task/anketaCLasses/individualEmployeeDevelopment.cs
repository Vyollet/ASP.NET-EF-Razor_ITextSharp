namespace Task.anketaCLasses
{
    public class individualEmployeeDevelopment
    {
        private static DataContext _context;

        public *(DataContext context)
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
            string developmentObjective = Request.Form["areaDevelopmentObjective"];
            string methodDevelopment = Request.Form["areaDevelopmentObjective"];
            string responsible = Request.Form["areaMethodDevelopment"];
            string dateStart = Request.Form["areaDateStart"];
            string dateEnd = Request.Form["areaDateEnd"];


            DataIndividualEmployeeDevelopment data = new DataIndividualEmployeeDevelopment()
            {
                IndividualEmployeeDevelopmentID = 0,
                DevelopmentObjective = developmentObjective,
                MethodDevelopment = methodDevelopment,
                Responsible = responsible,
                
                DateStart = dateStart,
                DateEnd = dateEnd
            };
        }
    }
}