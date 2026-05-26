using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCafeAutomation.Models
{
    [Table("Table_Session")]
    public class Session
    {
        [Key]
        public int Session_id { get; set; }

        public int? Customer_id { get; set; }
        public int? Computer_id { get; set; }
        public int? Game_id { get; set; }

        public DateTime? Start_Time { get; set; }
        public DateTime? End_Time { get; set; }

        public decimal? Total_Price { get; set; }

        [ForeignKey(nameof(Customer_id))]
        public virtual Customer Customer { get; set; }

        [ForeignKey(nameof(Computer_id))]
        public virtual Computer Computer { get; set; }

        [ForeignKey(nameof(Game_id))]
        public virtual Game Game { get; set; }
    }
}