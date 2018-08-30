namespace SA.GA.Common.Models
{
    #region Usings
         using System.Collections.Generic;
         using System.ComponentModel.DataAnnotations;
         using System.ComponentModel.DataAnnotations.Schema;
    #endregion
    [Table("Electricity")]
    public class Electricity : Entity
    {
        [Column("Year", TypeName = "int")]
        public int Year { get; set; }

        [Column("Mounth", TypeName = "int")]
        public int Mounth { get; set; }

        [Required]
        [Column("PreviousTestimony", TypeName = "decimal(10, 2)")]
        public double PreviousTestimony { get; set; }

        [Required]
        [Column("RecentTestimony", TypeName = "decimal(10, 2)")]
        public double RecentTestimony { get; set; }

        [Required]
        [Column("Losses", TypeName = "decimal(10, 2)")]
        public double Losses { get; set; }

        [Required]
        [Column("BankCollections", TypeName = "decimal(10, 2)")]
        public double BankCollections { get; set; }

        [Required]
        [Column("NecessaryToPlay", TypeName = "decimal(10, 2)")]
        public double NecessaryToPlay { get; set; }

        [Required]
        [Column("Paid", TypeName = "decimal(10, 2)")]
        public double Paid { get; set; }

        [Required]
        [Column("RateId", TypeName = "int")]
        public int RateId { get; set; }

        [ForeignKey("RateId")]
        public Rate Rate{ get; set; }

        public ICollection<Plot> Plot { get; set; }
    }
}