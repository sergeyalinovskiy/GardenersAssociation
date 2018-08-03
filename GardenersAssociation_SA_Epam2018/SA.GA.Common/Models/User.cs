namespace SA.GA.Common.Models
{
    #region Usings
    using System.Collections.Generic;
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
        [Column("Address", TypeName = "nvarchar(128)")]
        public string Address { get; set; }

        [Required]
        [Column("PhoneNumber", TypeName = "nvarchar(64)")]
        public string Phone { get; set; }

        [Required]
        [Column("SuppliedElectricity", TypeName = "bit")]
        public bool SuppliedElectricity { get; set; }

        [Required]
        [Column("AdditionalInformation", TypeName = "nvarchar(max)")]
        public string AdditionalInformation { get; set; }

        [Required]
        [Column("UserStatus", TypeName = "bit")]
        public bool Status { get; set; }


        public ICollection<History> Historys { get; set; }

    }
}
