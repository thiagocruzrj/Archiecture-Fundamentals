namespace ArchiectureFundamentals.Cases
{

    public interface IGenericRepository<T> where T : class
    {
        void Add(T obj);
    }
    public class GenericRepository<T> 
    {
        
    }
}