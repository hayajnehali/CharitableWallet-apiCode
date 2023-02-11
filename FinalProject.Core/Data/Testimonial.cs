using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.Core.Data
{
    public partial class Testimonial
    {
        public decimal Testimonialid { get; set; }
        public decimal? UseridFk { get; set; }
        public string Paragraph { get; set; }
        public decimal? Isaccept { get; set; }
        public decimal? Rate { get; set; }

        public virtual User UseridFkNavigation { get; set; }


    }
}
