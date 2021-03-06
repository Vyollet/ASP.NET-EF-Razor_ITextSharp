using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Task.anketaCLasses
{
    public class finalFormQuestionnaire : Controller
    {
        private static DataContext _context;

        
        public finalFormQuestionnaire(DataContext context)
        {
            _context = context;
        }
        

        public static void Generate(DataFinalFormQuestionnaire data)
        {
            var entity = _context.finalformquestionnaire.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            //*//
            
            DataFinalFormQuestionnaire data = new DataFinalFormQuestionnaire()
            {
                FinalFormQuestionnaireID = 0,
                IndividualEmployeeDevelopmentID = 0,
                IndividualEmployeeTasksID = 0,
                FinalEffectivenesDevelopmentID = 0,
                LevelCompetenceKnowledgeDevelopmentID = 0,
                EmployeeEffectivenessByManagerID = 0,
                EmployeeEffectivenessID = 0
            };
            Generate(data);
            return OnPost(name);
        }
    }
}