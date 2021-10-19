using Microsoft.EntityFrameworkCore;

namespace Task
{
    public class AnketaSotrudnik
    { 
        private static DataContext _context;
        public AnketaSotrudnik(DataContext context)
        {
            _context = context;
        }
        
        public static void Add(Data data)
        {
            var entity = _context.OpisanieZadach.Add(data);
            entity.State = EntityState.Added;

            _context.SaveChanges();
        }

        public static void Get()
        {

        }

    }
}
