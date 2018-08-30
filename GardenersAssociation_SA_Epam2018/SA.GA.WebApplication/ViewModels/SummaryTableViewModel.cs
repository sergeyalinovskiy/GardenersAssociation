namespace SA.GA.WebApplication.ViewModels
{
    public class SummaryTableViewModel
    {
        public int UserId { get; set; }

        public double PreviousTestimony { get; set; }

        public double RecentTestimony { get; set; }

        public double Consumption { get; set; }

        public double NecessaryToPay { get; set; }
    }
}