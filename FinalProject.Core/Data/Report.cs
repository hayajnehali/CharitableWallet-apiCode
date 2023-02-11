using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public partial class Report
    {
        
        public int Reportid { get; set; }
        public DateTime? Dateofreport { get; set; }
        public int Numberofbenificiaries { get; set; }
        public int Numberofdonations { get; set; }
        public int Numberofdoners { get; set; }
        public int Totaldonations { get; set; }
        public int Totalusers { get; set; }
        public decimal? UseridFk { get; set; }

        public virtual User UseridFkNavigation { get; set; }

    }
}
