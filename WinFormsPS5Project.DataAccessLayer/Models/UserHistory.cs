using System;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class UserHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Operation { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
