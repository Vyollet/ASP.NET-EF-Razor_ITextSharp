using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Task.anketaCLasses
{
    public class employeeEffectiveness
    {
      
       private static DataContext _context;

        public *(DataContext context)
        {
            _context = context;
        }

        public static void Add(DataEmployeeEffectiveness data)
        {
            var entity = _context.employeeEffectivenesses.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            string zadachi = Request.Form["areaZadacha"];
            string achivement = Request.Form["areaAchivement"];
            string whatWantImprove = Request.Form["areaWhatWantImpove"];
            string additionalWork = Request.Form["areaAdditionalWork"];


            DataEmployeeEffectiveness data = new DataEmployeeEffectiveness()
            {
                EmployEffectivenessID = 0,
                Zadacha = zadachi,
                Achivement = achivement,
                WhatWantImprove = whatWantImprove,
                AdditionalWork =  additionalWork;
            };
        }
}