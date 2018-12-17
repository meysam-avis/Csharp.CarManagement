using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Models
{
   public  class Mamoriat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DriverId { get; set; }
        public int UserId { get; set; }
        public string ShomareNameh { get; set; }
        public string Mabda { get; set; }
        public string Maghsad { get; set; }
        public string TarikhRaft { get; set; }
        public string TarikhBargasht { get; set; }

        public string ZamanRaft { get; set; }
        public string ZamanBargasht { get; set; }
        public bool Deleted { get; set; } = false;
       public int? KilometerRaft { get; set; }
        public int? KilometerBargasht { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("DriverId")]
        public virtual Driver Driver { get; set; }
        public virtual bool Finished { get; set; } = false;


    }
}
