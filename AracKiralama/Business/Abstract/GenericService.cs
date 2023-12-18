namespace AracKiralama.Business.Abstract
{
    public interface IGenericService<T>
    {
        public void Add(T t);
        public void Delete(T t);
        public void Update(T t);
        public T Get(int id);
        public List<T> List();
    }
}
