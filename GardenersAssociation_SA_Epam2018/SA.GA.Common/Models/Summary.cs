using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Common.Models   
{
    public class Summary
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public double PreviousTestimony { get; set; }
        public double RecentTestimony { get; set; }
        public double Consumption { get; set; }
        public double NecessaryToPay { get; set; }
    }
}
