namespace SA.GA.Common.Models
{
    using System.Collections.Generic;
    #region
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    #endregion

    [Table("User")]
    public class User : Entity
    {
        [Required]
        [Column("FirstName", TypeName = "nvarchar(64)")]
        public string FirstName { get; set; }

        [Required]
        [Column("LastName", TypeName = "nvarchar(64)")]
        public string LastName { get; set; }

        [Required]
        [Column("MiddleName", TypeName = "nvarchar(64)")]
        public string MiddleName { get; set; }

        [Required]
        [Column("SiteNumber", TypeName = "int")]
        public string SiteNumber { get; set; }

        [Required]
        [Column("LastName", TypeName = "nvarchar(128)")]
        public string Address { get; set; }

        [Required]
        [Column("Phone", TypeName = "nvarchar(64)")]
        public string Phone { get; set; }

        [Required]
        [Column("SuppliedElectricity", TypeName = "bit")]
        public bool SuppliedElectricity { get; set; }

        [Required]
        [Column("AdditionalInformation", TypeName = "nvarchar(max)")]
        public string AdditionalInformation { get; set; }

        [Required]
        [Column("Status", TypeName = "bit)")]
        public bool Status { get; set; }

        //[Required]
        //[Column("HistoryId", TypeName = "int)")]
        //public int HistoryId { get; set; }

        //[ForeignKey("HistoryId")]
        //public Plot Plot { get; set; }

        public ICollection<History> History { get; set; }

    }
}
