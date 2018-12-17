using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Car.Models;
using Car.ViewModels;

namespace Car.Controllers
{
    public class AvarezController : IBaseDatabaseOperation<Avarez>
    {
        public void Create(Avarez t)
        {


            using (var db = new CarDB())
            {

                db.Avarezha.Add(t);

                db.SaveChanges();
            }
        }

        public List<Avarez> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AvarezViewModel> GetAllDGV()
        {
            using (var db = new CarDB())
            {
                return db.Avarezha.Where(p => !p.Deleted).Include(p => p.Car).Select(p => new AvarezViewModel
                {

                    Id = p.Id,
                    Price = p.Price,
                    Pelak = p.Car.Pelak,
                    Rahgiri = p.Rahgiri,
                    Tarikh = p.Tarikh,
                    shrAvarezType = p.AvarezType,
                    strAvarezType = p.AvarezType == 0 ? "سالیانه" : "جاده ای"


                }).ToList();

            }
        }


        public void Delete(int id)
        {
            using (var db = new CarDB())
            {
                var a = db.Avarezha.Find(id);
                a.Deleted = true;
                db.SaveChanges();
            }
        }

        public List<Avarez> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Avarez t)
        {

            using (var db = new CarDB())
            {
                var a = db.Avarezha.Find(t.Id);
                a.CarId = t.CarId;
                a.Rahgiri = t.Rahgiri;
                a.Deleted = t.Deleted;
                a.Price = t.Price;
                a.Tarikh = t.Tarikh;
                db.SaveChanges();

            }


        }

        public Avarez Get(int id)
        {
            using (var db = new CarDB())
            {
                return db.Avarezha.Include(p => p.Car).SingleOrDefault(p => p.Id == id);
                
            }
        }
    }
}
