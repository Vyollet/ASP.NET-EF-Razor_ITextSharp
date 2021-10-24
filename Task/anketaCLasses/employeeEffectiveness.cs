using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

    

namespace Task.anketaCLasses
{
    public class employeeEffectiveness : Controller
    {

        private static DataContext _context;

        public employeeEffectiveness(DataContext context)
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
            string zadachi = "areaZadacha";
            string achivement = "areaAchivement";
            string whatWantImprove = "areaWhatWantImpove";
            string additionalWork = "areaAdditionalWork";


            DataEmployeeEffectiveness data = new DataEmployeeEffectiveness()
            {
                EmployeeEffectivenessID = 0,
                Zadacha = zadachi,
                Achivement = achivement,
                WhatWantImprove = whatWantImprove,
                AdditionalWork = additionalWork
            };
            Add(data);
            return OnPost(name);
        }
    }
}