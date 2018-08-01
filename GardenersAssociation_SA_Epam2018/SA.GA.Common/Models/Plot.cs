﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SA.GA.Common.Models
{
    [Table("Plot")]
    public class Plot : Entity
    {        
        [Required]
        [Column("AdditionalPlotId", TypeName = "int")]
        public int AdditionalPlotId { get; set; }

        [Required]
        [Column("Area", TypeName = "decimal(10, 2)")]
        public double Area { get; set; }

        [Required]
        [Column("Privatized", TypeName = "bit")]
        public bool Privatized { get; set; }

        [Required]
        [Column("UserId", TypeName = "int")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public virtual ICollection<History> History { get; set; }

        public virtual ICollection<Rate> Rate { get; set; }


    }
}
