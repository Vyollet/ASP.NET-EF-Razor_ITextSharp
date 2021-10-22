namespace Task.anketaCLasses
{
    public class levelAssessmentCompetenceDevelopment
    {
        private static DataContext _context;

        public *(DataContext context)
        {
            _context = context;
        }

        public static void Add(DataLevelCompetenceKnowledgeDevelopment data)
        {
            var entity = _context.levelcompetenceknowledgedevelopment.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string evaluenceManager = Request.Form["areaEvaluenceManager"];
            string evaluenceEmployee = Request.Form["areaEvaluenceEmployee"];
            string averageValueKnowledge = Request.Form["areaAverageValueKnowledge"];
            string evaluenceCompetence = Request.Form["areaEvaluenceCompetence"];
            string averageValueDevelopment = Request.Form["areaAverageValueDevelopment"];
            int sumValueKnowledge = Request.Form["areaSumValueKnowledge"];
            int finalEvaluenceDevelopment = Request.Form["areaFinalEvaluenceDevelopment"];

            DataLevelCompetenceKnowledgeDevelopment data = new DataLevelCompetenceKnowledgeDevelopment()
            {
                LevelCompetenceKnowledgeDevelopmentID = 0,
                EvaluenceManager = evaluenceManager,
                EvaluenceEmployee = evaluenceEmployee,
                AverageValueKnowledge = averageValueKnowledge,
                
                EvaluenceCompetence = evaluenceCompetence,
                AverageValueDevelopment = averageValueDevelopment,

                SumValueKnowledge = sumValueKnowledge,
                FinalEvaluenceDevelopment = finalEvaluenceDevelopment
            };
        }
    }
}