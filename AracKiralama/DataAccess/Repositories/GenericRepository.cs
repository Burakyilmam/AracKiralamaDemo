using AracKiralama.Models;

namespace AracKiralama.DataAccess.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }
    }
}
