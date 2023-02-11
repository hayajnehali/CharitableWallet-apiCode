using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public partial class Donation
    {
        public decimal Donationid { get; set; }
        public DateTime? Datedonation { get; set; }
        public decimal? Userfk { get; set; }
        public decimal? Charityfk { get; set; }
        public decimal? Amount { get; set; }

        public virtual Cahrity CharityfkNavigation { get; set; }
        public virtual User UserfkNavigation { get; set; }
    }
}
