using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;

namespace Car.Models
{
    public class Avarez
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarId { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string Rahgiri { get; set; }
        public short AvarezType { get; set; }
        public bool Deleted { get; set; }
        public Car Car { set; get; }
    }
}
