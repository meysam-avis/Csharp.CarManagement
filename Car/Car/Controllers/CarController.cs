using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
 public    class CarController:IBaseDatabaseOperation<Models.Car>
    {
        public void Create(Models.Car t)
        {


            using (var db = new CarDB())
            {

                db.Cars.Add(t);

                db.SaveChanges();
            }
        }

        public List<Models.Car> GetAll()
        {


            using (var db = new CarDB())
            {
                return db.Cars.Where(p => !p.Deleted).ToList();

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Models.Car> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.Car t)
        {
            throw new NotImplementedException();
        }

        public Models.Car Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
