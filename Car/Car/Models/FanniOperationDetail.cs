using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    public class FanniOperationDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FanniId { get; set; }
        public int FanniOperationId { get; set; }
        public Fanni Fanni { set; get; }
        public FanniOperation FanniOperation { set; get; }
    }
}
