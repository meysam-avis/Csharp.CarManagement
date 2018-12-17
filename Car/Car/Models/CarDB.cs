using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;
using Car.Migrations;
using Car.Shared;


namespace Car.Models
{
    public class CarDB : DbContext
    {

        public CarDB() : base(Cryptography.Decrypt(Registery.GetConnectionString(), Program.AesKey))
        {

            //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarDB, Configuration>());
            // Database.SetInitializer<CarDB>(new DropCreateDatabaseAlways<CarDB>());
            Database.SetInitializer<CarDB>(null);

        }
     
       public DbSet<Avarez > Avarezha { get; set; }
      public DbSet<User> Users { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Vahed> Vahedha { get; set; }
        public DbSet<Mamoriat> Mamoriatha { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Bimeh> Bimeha { get; set; }
        public DbSet<Fuel > Fuels { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Tasadof> Tasadofat { get; set; }
        public DbSet<Fanni> FanniDbSet { get; set; }
        public DbSet<FanniOperation> FanniOperations { get; set; }
        public DbSet<FanniOperationDetail> FanniOperationDetails { get; set; }
        public DbSet<PersonalCar> PersonalCars { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
