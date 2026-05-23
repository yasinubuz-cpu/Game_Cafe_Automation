using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace GameCafeAutomation.Models
{
    [Table("Table_Computer")]
    public class Computer
    {
        public Computer()
        {
            Sessions = new HashSet<Session>();
        }

        [Key]
        public int Computer_id { get; set; }

        [Required, MaxLength(50)]
        public string Computer_name { get; set; }

        [Required, MaxLength(30)]
        public string Computer_status { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
