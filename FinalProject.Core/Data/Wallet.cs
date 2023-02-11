using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.Core.Data
{
    public partial class Wallet
    {
        public decimal Walletid { get; set; }
        public decimal? Balance { get; set; }
        public decimal? UseridFk { get; set; }
        public decimal? BankaccountFk { get; set; }

        public virtual Bankaccount BankaccountFkNavigation { get; set; }
        public virtual User UseridFkNavigation { get; set; }
    }
}
