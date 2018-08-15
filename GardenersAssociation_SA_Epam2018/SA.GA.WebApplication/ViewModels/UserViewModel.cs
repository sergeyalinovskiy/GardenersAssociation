namespace SA.GA.WebApplication.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; } 

        public string FirstName { get; set; }
                
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool SuppliedElectricity { get; set; }

        public string AdditionalInformation { get; set; }

        public bool Status { get; set; }
    }
}
