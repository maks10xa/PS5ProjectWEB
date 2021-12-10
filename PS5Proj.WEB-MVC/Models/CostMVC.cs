using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS5Proj.WEB_MVC.Models
{
    public class CostMVC
    {
        public int Id { get; set; }
        public string TimePeriod { get; set; }
        public decimal CostOfPeriod { get; set; }
    }
}
