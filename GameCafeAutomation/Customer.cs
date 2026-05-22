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
    [Table("Table_Customer")]
    public class Customer
    {
        public Customer()
        {
            Sessions = new HashSet<Session>();
        }

        [Key]
        public int Customer_id { get; set; }

        [Required, MaxLength(50)]
        public string Customer_name { get; set; }

        [Required, MaxLength(50)]
        public string Customer_surname { get; set; }

        [Required, MaxLength(50)]
        public string Cusomer_phone { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
