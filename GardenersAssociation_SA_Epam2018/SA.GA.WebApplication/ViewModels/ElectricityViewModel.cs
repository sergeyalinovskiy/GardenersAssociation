namespace SA.GA.WebApplication.ViewModels
{
    public class ElectricityViewModel
    {
        public int Id { get; set; }

        public int Year { get; set; }
        
        public int Mounth { get; set; }

        public double PreviousTestimony { get; set; }

        public double RecentTestimony { get; set; }

        public double Losses { get; set; }

        public double BankCollections { get; set; }

        public double NecessaryToPlay { get; set; }

        public double Paid { get; set; }

        public int RateId { get; set; }
    }
}