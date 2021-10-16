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

        public static void Get()
        {
            var context = new DataContext();
            foreach (Data data in context.OpisanieZadach)
            {
                
            }
        }

    }
}
