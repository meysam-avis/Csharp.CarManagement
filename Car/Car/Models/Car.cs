using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Pelak { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int? VahedId { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Personal { get; set; } = false;
        [ForeignKey("VahedId")]
        public Vahed Vahed { get; set; }
       public ICollection<Mamoriat> Mamoriatha { get; set; }
        public ICollection<Bimeh> Bimeha { get; set; }
    }
}
