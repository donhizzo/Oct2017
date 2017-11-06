using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Interfaces
{
    public interface IBaseRepository
    {
        object Get(int id);
        IEnumerable<object> Get();
        bool Create(object o);
        bool Update(object o);
        bool Delete(int id);
    }

    // the use of generics
    public interface IBaseRepository <T> where T : class
    {
        object Get(T id);
        IEnumerable<T> Get();
        bool Create(T o);
        bool Update(T o);
        bool Delete(T id);
    }
}
