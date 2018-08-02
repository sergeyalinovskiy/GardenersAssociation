namespace SA.GA.Common.Models
{
    #region Usings
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    #endregion
    [Table("History")]
    public class History: Entity
    {
        [Required]
        [Column("UserId", TypeName = "int")]
        public int UserId { get; set; }

        [Required]
        [Column("PlotId", TypeName = "int")]
        public int PlotId { get; set; }

        [Required]
        [Column("From", TypeName = "datetime")]
        public DateTime From { get; set; }
        
        [Column("To", TypeName = "datetime")]
        public DateTime To { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("PlotId")]
        public Plot Plot { get; set; }
    }
}
