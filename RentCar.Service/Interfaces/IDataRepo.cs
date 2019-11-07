using System.Collections.Generic;

namespace RentCar.Service.Interfaces
{
    public interface IDataRepo<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Save(T model);
        void Delete(T model);
    }
}
