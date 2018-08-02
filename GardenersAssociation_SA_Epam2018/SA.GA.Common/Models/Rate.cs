namespace SA.GA.Common.Models
{
    #region Usings
        using System;
        using System.Collections.Generic;
        using System.ComponentModel.DataAnnotations;
        using System.ComponentModel.DataAnnotations.Schema;
    #endregion

    [Table("Rate")]
    public class Rate : Entity
    {
        [Required]
        [Column("Name", TypeName = "nvarchar(128)")]
        public string Name{ get; set; }
        [Required]
        [Column("Value", TypeName = "decimal(10, 2)")]
        public double Value { get; set; }
        [Required]
        [Column("From", TypeName = "datetime")]
        public DateTime From { get; set; }
       
        [Column("To", TypeName = "datetime")]
        public DateTime To { get; set; }

        public virtual ICollection<Electricity> Electricity { get; set; }
    }
}