namespace SA.GA.WebApplication.ViewModels
{
    #region Usings
        using System.ComponentModel.DataAnnotations;
    #endregion
    public class UserViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }
     
        public bool SuppliedElectricity { get; set; }

        [Required]
        public string AdditionalInformation { get; set; }
       
        public bool Status { get; set; }
     
        public string ViewSuppliedElectricity { get; set; }
       
        public string ViewStatus { get; set; }
    }
}