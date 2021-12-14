using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsPS5Project.DataAccessLayer.Models
{
    public partial class User
    {
        public User()
        {
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Pass { get; set; }
        public string UserName { get; set; }
        public bool AdminPs { get; set; }
        public string FavoriteGame { get; set; }
        public int? GameId { get; set; }
        public int? ContactsId { get; set; }
        public decimal? Balance { get; set; }

        public virtual Contact ContactsNavigation { get; set; }
        public virtual Game Game { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
