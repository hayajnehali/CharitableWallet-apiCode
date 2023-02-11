using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class Bankaccount
    {
        public Bankaccount()
        {
            Wallets = new HashSet<Wallet>();
        }

        public decimal Accountid { get; set; }
        public decimal? Balance { get; set; }
        public string Accountnum { get; set; }
        public DateTime? Expireddate { get; set; }
        public string Cvv { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
