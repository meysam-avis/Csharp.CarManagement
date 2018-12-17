using Car.Infrastructure;
using Car.Models;
using Car.Shared;

namespace Car.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Car.Models.CarDB>
    {
        public Configuration()
        {
         AutomaticMigrationsEnabled = true;
         //   AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Car.Models.CarDB context)
        {
           

            context.Vahedha.AddOrUpdate(
                p => p.Name,
                new Vahed { Deleted = false, Name = "اداره کل" }

            );
            context.Roles.AddOrUpdate(
                 p => p.Name,
                new Role { Name = "کاربر", Permission = "user" },
                 new Role { Name = "مدیر ", Permission = "admin" },
                 new Role { Name = "برنامه نویس", Permission = "superAdmin" }
              
                
             );


            context.SaveChanges();

            context.Users.AddOrUpdate(
                p => p.Username,
            new User { Username = "2060817579", CellPhone = "09111199197", Name = " میثم آویس ", MelliCode = "2060817579", RoleId = 3, Password = "3987", VahedId =1, LastLoginDateTime = DateTime.UtcNow },
                new User { Username = "2093822598", CellPhone = "09119566189", Name = "سید محمد نبوی", MelliCode = "2093822598", RoleId = 4, Password = "123", VahedId =1, LastLoginDateTime = DateTime.UtcNow }

            );

            context.Drivers.AddOrUpdate(
                p => p.Name,
                new Driver {Name = "الیاس فتحی", CellPhone = "0911120154", MelliCode = "205412548" }

            );


            context.FuelTypes.AddOrUpdate(
                p => p.Name,
                new FuelType { Name = "بنزین" },
                new FuelType { Name = "گاز" }

            );

            context.FanniDbSet.AddOrUpdate(
                p => p.Name,
                new Fanni { Name = "تعویض روغن" },
                new Fanni { Name = "تعویض لاستیک" },
                new Fanni { Name = "تعویض فیلتر هوا" },
                new Fanni { Name = "تعویض روکش صندلی" },
                new Fanni { Name = "سایر" }


            );
          


        }
    }
}
