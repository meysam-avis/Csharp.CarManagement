using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Models
{
  public   class Bimeh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarId { get; set; }

        public string Name { get; set; }
        public string Shomareh { get; set; }
        public string TarikhSodour { get; set; }
        public string  TarikhEngheza { get; set; }
       public long Price { get; set; }
        public BimehType Type { get; set; }
        public bool Deleted { get; set; }
        public Car Car { set; get; }

    }
}
