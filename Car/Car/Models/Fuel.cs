using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Models
{
  public   class Fuel
    {
         
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarId { get; set; }
        public int FuelTypeId { get; set; }

        public int Kilometer { set; get; }
        public string FactorNumber { set; get; }
        public long Mablagh { set; get; }
        public string TarikhPardakht { set; get; }
        public bool Deleted { get; set; }

        [ForeignKey("CarId")]
        public Car Car { set; get; }

        [ForeignKey("FuelTypeId")]
        public FuelType FuelType { get; set; }
    }
}
