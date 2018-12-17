using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;
using Car.ViewModels;

namespace Car.Controllers
{
    public class BimehController : IBaseDatabaseOperation<Bimeh>
    {
        public void Create(Bimeh t)
        {
            using (var db = new CarDB())
            {

                db.Bimeha .Add(t);

                db.SaveChanges();
            }
        }

        public List<Bimeh> GetAll()
        {
            using (var db = new CarDB())
            {
                return db.Bimeha.
                    Include(p => p.Car).
                    Where(p => !p.Deleted).ToList();
            }
        }

        public List<BimehViewModel> GetAllDGV()
        {
            using (var db = new CarDB())
            {
                return db.Bimeha.Where(p => !p.Deleted).Include(p => p.Car).Select(p => new BimehViewModel
                {

                    Id = p.Id,
             Pelak = p.Car.Pelak,
             Name = p.Name ,
             Price = p.Price,
             Shomareh = p.Shomareh ,
             TarikhEngheza = p.TarikhEngheza,
            TarikhSodour = p.TarikhSodour,
                   Type = p.Type ,
                   StrType = p.Type.ToString()
            
                }).ToList();

            }
        }

        public void Delete(int id)
        {
            using (var db = new CarDB())
            {
                var b = db.Bimeha.Find(id);
                b.Deleted = true;
                db.SaveChanges();
            }

        }

        public List<Bimeh> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Bimeh t)
        {
            using (var db = new CarDB())
            {
                var b = db.Bimeha.Find(t.Id);
                b.CarId = t.CarId;
                b.Type = t.Type;
                b.Name = t.Name;
                b.Price = t.Price;
                b.Shomareh = t.Shomareh;
                b.TarikhEngheza = t.TarikhEngheza;
                b.TarikhSodour = t.TarikhSodour;
              
                db.SaveChanges();
            }
        }

        public Bimeh Get(int id)
        {
            using (var db = new CarDB())
            {
                return db.Bimeha.Include(p => p.Car)
                    .SingleOrDefault(p => p.Id == id);

            }
        }
    }
}
