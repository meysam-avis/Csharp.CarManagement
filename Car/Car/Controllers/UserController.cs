using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;
using Car.Shared;

namespace Car.Controllers
{
   public  class UserController: IBaseDatabaseOperation<Models.User>
    {
        public void Create(User t)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get(string name)
        {
            throw new NotImplementedException();
        }
        public User Get(string melliCode,string password)
        {
            try
            {

                using (var db=new CarDB())
                {
                 return  db.Users.First(p => p.Username == melliCode && p.Password ==password);
                }
             
                }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLoginDate(int uId)
        {
            using (var db = new CarDB())
            {
                var u = db.Users.Find(uId);
                u.LastLoginDateTime = DateTime.UtcNow;
                db.SaveChanges();
            }
        }
    }
}
