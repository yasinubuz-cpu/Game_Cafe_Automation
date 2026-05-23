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
    [Table("Table_Game")]
    public class Game
    {
        public Game()
        {
            Sessions = new HashSet<Session>();
        }

        [Key]
        public int Game_id { get; set; }

        [Required, MaxLength(50)]
        public string Game_name { get; set; }

        [Required, MaxLength(50)]
        public string Game_category { get; set; }

        [Required, MaxLength(10)]
        public string Hourly_price { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}