using System.Collections.Generic;
namespace CapgeminiTest.DAL {
    public interface IRepository<T> {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
    }
}