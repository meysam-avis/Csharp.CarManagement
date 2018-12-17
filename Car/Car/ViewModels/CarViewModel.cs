using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.ViewModels
{
   public  class CarViewModel
    {
        
        public int Id { get; set; }
        public string Nam { get; set; }
        public string Pelak { get; set; }
        public string PelakPart1 { get; set; }
        public string PelakPart2 { get; set; }
        public string PelakPart3 { get; set; }
        public string Rang { get; set; }
        public string Model { get; set; }
        public int? VahedId { get; set; }
        public bool Deleted { get; set; } = false;

        public  CarViewModel()
        {
          //  Pelak=string.Format("{0}{1}{2}",PelakPart1.)
        }

    }
}
