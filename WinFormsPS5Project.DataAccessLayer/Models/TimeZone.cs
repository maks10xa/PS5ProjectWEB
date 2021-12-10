using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class TimeZone
    {
        public int Id { get; set; }
        public string TimeZoneName { get; set; }
        public DateTime TimeOfTimeZone { get; set; }
    }
}
