using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    public class Vahed
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { set; get; } = "اداره کل";
        public bool Deleted { set; get; } = false;
        public ICollection<Car> Cars { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
