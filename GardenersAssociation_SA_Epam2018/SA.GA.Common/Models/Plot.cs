namespace SA.GA.Common.Models
{
    #region Usings
         using System.Collections.Generic;
         using System.ComponentModel.DataAnnotations;
         using System.ComponentModel.DataAnnotations.Schema;
    #endregion

    [Table("Plot")]
    public class Plot : Entity
    {        
        
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

        [Required]
        [Column("ElectricityId", TypeName = "int")]  
        public int ElectricityId { get; set; }

        [ForeignKey("ElectricityId")]
        public Electricity Electricity { get; set; }

        public ICollection<History> Historys { get; set; }
    }
}