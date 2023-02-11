using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class Report
    {
        public decimal Reportid { get; set; }
        public decimal? UseridFk { get; set; }
        public decimal? Numberofdonations { get; set; }
        public decimal? Numberofdoners { get; set; }
        public decimal? Numberofbenificiaries { get; set; }
        public DateTime? Dateofreport { get; set; }
        public decimal? Totalusers { get; set; }
        public decimal? Totaldonations { get; set; }

        public virtual User UseridFkNavigation { get; set; }
    }
}
