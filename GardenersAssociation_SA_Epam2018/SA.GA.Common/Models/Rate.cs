using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.Common.Models
{
    public class Rate : Entity
    {
        public string Name{ get; set; }
        public double Value { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
