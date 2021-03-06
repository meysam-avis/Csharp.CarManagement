﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    public class Driver
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string CellPhone { get; set; }
        public string MelliCode { get; set; }
        public bool Deleted { get; set; } = false;
        public ICollection<Mamoriat> Mamoriatha { get; set; }
    }
}
