using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task
{
    public static class AnketaSotrudnik
    { 

        public static void Add(Data data)
        {
            var context = new DataContext();
            var entity = context.OpisanieZadach.Add(data);
            entity.State = EntityState.Added;

            context.SaveChanges();
        }


        /*public static void GetAll()
        {
            var context = new DataContext();
            if (context.OpisanieZadach.Any())
            {
                var data = context.OpisanieZadach.ToList();
                /*foreach (var Datas in data)
                {
                    Console.WriteLine($"ID:{Datas.Id}; Product Name:{Datas.OpisanieZadach1}");
                }#1#
            }
            else
            {
                Console.WriteLine("NO");
            }
        }*/

    }
}
