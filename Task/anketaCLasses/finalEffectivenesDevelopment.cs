using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Task.anketaCLasses
{
    public class finalEffectivenesDevelopment : Controller
    { 
        private static DataContext _context;

        
        public finalEffectivenesDevelopment(DataContext context)
        {
            _context = context;
        }
        

        public static void Add(DataFinalEffectivenesDevelopment data)
        {
            var entity = _context.finaleffectivenesdevelopment.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string evaluenceEffectivenes = "areaEvaluenceEffectivenes";
            string evaluenceComptenece = "areaEvaluenceComptenece";
            string finalEvaluenceEffectivenes = "areaFinalEvaluenceEffectivenes";
            string proposalsEstablishmentProfessionalStatus = "areaProposalsEstablishmentProfessionalStatus";


            DataFinalEffectivenesDevelopment data = new DataFinalEffectivenesDevelopment()
            {
                FinalEffectivenesDevelopmentID = 0,
                EvaluenceEffectivenes = evaluenceEffectivenes,
                EvaluenceComptenece = evaluenceComptenece,
                FinalEvaluenceEffectivenes = finalEvaluenceEffectivenes,
                ProposalsEstablishmentProfessionalStatus = proposalsEstablishmentProfessionalStatus,
            };
            Add(data);
            return OnPost(name);
        }
    }
}