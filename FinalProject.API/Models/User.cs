using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class User
    {
        public User()
        {
            Cahrities = new HashSet<Cahrity>();
            Documents = new HashSet<Document>();
            Donations = new HashSet<Donation>();
            Reports = new HashSet<Report>();
            Testimonials = new HashSet<Testimonial>();
            Wallets = new HashSet<Wallet>();
        }

        public decimal Userid { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Phonenumber { get; set; }
        public string Imagepath { get; set; }
        public decimal? Isaccepted { get; set; }
        public decimal? Roleidfk { get; set; }

        public virtual Role RoleidfkNavigation { get; set; }
        public virtual ICollection<Cahrity> Cahrities { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Testimonial> Testimonials { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
