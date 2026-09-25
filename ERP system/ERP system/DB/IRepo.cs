using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system.DB
{
    public interface IRepo<T>
    {
        bool Add(T value);
        T FindById(int id);
        bool update(int id, string name, string email, string phone);
        IEnumerable<T> GetAll();
    }
}
