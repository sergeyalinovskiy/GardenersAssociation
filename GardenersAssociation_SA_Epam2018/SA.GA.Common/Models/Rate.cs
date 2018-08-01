using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SA.GA.Common.Models
{
    public class Rate : Entity
    {
        [Required]
        [Column("Name", TypeName = "nvarchar(64)")]
        public string Name{ get; set; }
        [Required]
        [Column("Value", TypeName = "decimal(10, 2)")]
        public double Value { get; set; }
        [Required]
        [Column("From", TypeName = "datetime")]
        public DateTime From { get; set; }
        [Required]
        [Column("To", TypeName = "datetime")]
        public DateTime To { get; set; }


        public virtual ICollection<Electricity> Electricity { get; set; }
    }
}
