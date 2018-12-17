using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;
using Car.Models;


namespace Car.Shared
{
public static class Common {
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    public static void SetUserActivity(UserActivityType ut, string message)
    {
        using (var db = new CarDB())
        {
            var ua = new UserActivity();
            ua.Description = message;
            ua.UserId = Program.User.Id;
            ua.UserActivityType = ut;

        }

    }


    public static string BuildEntityConnection(string connectionString)
    {
        var entityConnection = new EntityConnectionStringBuilder
        {
            Provider = "System.Data.SqlClient",
            ProviderConnectionString = connectionString

           
        };

        return entityConnection.ToString();
    }





    }
}
