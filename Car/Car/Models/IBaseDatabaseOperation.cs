using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
   public interface  IBaseDatabaseOperation<T>
    {

        void Create(T t);
        List<T> GetAll();
        void Delete(int id);
        List<T> Get(string name);
        void Update(T t);
        T Get(int id);
    }
}
