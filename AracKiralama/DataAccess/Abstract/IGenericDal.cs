namespace AracKiralama.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        public void Add(T t);
        public void Delete(T t);
        public void Update(T t);
        public T Get(int id);
        public List<T> List();

    }
}
