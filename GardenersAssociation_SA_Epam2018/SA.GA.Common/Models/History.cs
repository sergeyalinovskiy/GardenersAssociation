using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SA.GA.Common.Models
{
    [Table("History")]
    public class History
    {
        public int UserId { get; set; }
        public int PlotId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("PlotId")]
        public Plot Plot { get; set; }
    }
}
