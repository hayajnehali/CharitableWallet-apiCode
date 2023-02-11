using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public  class DonationDto
    {
        public decimal Donationid { get; set; }
        public DateTime? Datedonation { get; set; }
        public decimal? Amount { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CHARITYNAME { get; set; }
        public decimal? State { get; set; }

    }
}
