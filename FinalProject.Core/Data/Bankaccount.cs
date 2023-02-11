using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.Core.Data
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
        public DateTime? EXPIREDDATE { get; set; }
        public string FULLNAME { get; set; }
        public string CVV { get; set; }

        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
