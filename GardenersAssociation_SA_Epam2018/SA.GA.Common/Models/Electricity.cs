﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SA.GA.Common.Models
{
    [Table("Electricity")]
    public class Electricity : Entity
    {
        [Required]
        [Column("Year", TypeName = "int")]
        public int Year { get; set; }

        [Required]
        [Column("Mounth", TypeName = "int")]
        public int Mounth { get; set; }

        [Required]
        [Column("PreviousTestimony", TypeName = "decimal(10, 2)")]
        public double PreviousTestimony { get; set; }

        [Required]
        [Column("RecentTestimony", TypeName = "decimal(10, 2)")]
        public double RecentTestimony { get; set; }

        [Required]
        [Column("Rate", TypeName = "nvarchar(64)")]
        public string Rate { get; set; }

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
        [Column("UserId", TypeName = "int")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
