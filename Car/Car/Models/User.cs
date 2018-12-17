using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
       // public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual DateTime LastLoginDateTime { set; get; }
        public int? VahedId { get; set; }
        public string CellPhone { get; set; }
        public string MelliCode { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [ForeignKey("VahedId")]
        public Vahed Vahed { get; set; }
        public  ICollection<UserActivity> UserActivities { set; get; }
        public ICollection<Mamoriat> Mamoriatha { get; set; }

    }
}
