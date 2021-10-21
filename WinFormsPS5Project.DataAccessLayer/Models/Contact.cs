using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string AdminName { get; set; }
        public string PhoneNumber { get; set; }

        public virtual User User { get; set; }
    }
}
