namespace Task.anketaCLasses
{
    public class finalEffectivenesDevelopment
    {
        private static DataContext _context;

        public *(DataContext context)
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
            string evaluenceEffectivenes = Request.Form["areaEvaluenceEffectivenes"];
            string evaluenceComptenece = Request.Form["areaEvaluenceComptenece"];
            string finalEvaluenceEffectivenes = Request.Form["areaFinalEvaluenceEffectivenes"];
            string proposalsEstablishmentProfessionalStatus = Request.Form["areaProposalsEstablishmentProfessionalStatus"];


            DataFinalEffectivenesDevelopment data = new DataFinalEffectivenesDevelopment()
            {
                FinalEffectivenesDevelopmentID = 0,
                EvaluenceEffectivenes = evaluenceEffectivenes,
                EvaluenceComptenece = evaluenceComptenece,
                FinalEvaluenceEffectivenes = finalEvaluenceEffectivenes,
                ProposalsEstablishmentProfessionalStatus = proposalsEstablishmentProfessionalStatus,
            };
        }
    }
}