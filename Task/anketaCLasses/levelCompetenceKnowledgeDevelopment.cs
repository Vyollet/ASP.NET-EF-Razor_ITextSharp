using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Task.anketaCLasses
{
    public class levelAssessmentCompetenceDevelopment : Controller
    {
        private static DataContext _context;
        
        public levelAssessmentCompetenceDevelopment(DataContext context)
        {
            _context = context;
        }
        

        public static void Add(DataLevelCompetenceKnowledgeDevelopment data)
        {
            var entity = _context.levelcompetenceknowledgedevelopment.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm]  string name)
        {
            string evaluenceManager = "areaEvaluenceManager";
            string evaluenceEmployee =  "areaEvaluenceEmployee" ;
            string averageValueKnowledge =  "areaAverageValueKnowledge" ;
            string evaluenceCompetence =  "areaEvaluenceCompetence" ;
            string averageValueDevelopment =  "areaAverageValueDevelopment" ;
            int sumValueKnowledge = 0; //"areaSumValueKnowledge" ;
            int finalEvaluenceDevelopment = 0; //"areaFinalEvaluenceDevelopment" ;

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
            Add(data);
            return OnPost(name);
        }
    }
}