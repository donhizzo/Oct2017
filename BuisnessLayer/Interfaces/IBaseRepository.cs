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
}
