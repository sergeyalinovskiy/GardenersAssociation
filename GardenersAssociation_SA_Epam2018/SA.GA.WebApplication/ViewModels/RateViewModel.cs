using System;
namespace SA.GA.WebApplication.ViewModels
{
    public class RateViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public double Value { get; set; }
        
        public DateTime From { get; set; }

        public DateTime To { get; set; }

    }
}
