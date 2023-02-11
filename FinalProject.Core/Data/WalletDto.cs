using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public class WalletDto
    {
        public decimal Walletid { get; set; }
        public decimal? Balance { get; set; }
    
        public string Accountnum { get; set; }
        public DateTime? EXPIREDDATE { get; set; }
        public string FULLNAME { get; set; }
    }
}
