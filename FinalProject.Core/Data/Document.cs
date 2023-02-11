using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.Core.Data
{
    public partial class Document
    {
        public decimal Docid { get; set; }
        public string Docname { get; set; }
        public string Doc { get; set; }
        public decimal? UseridFk { get; set; }
        public decimal? CharityidFk { get; set; }

        public virtual Cahrity CharityidFkNavigation { get; set; }
        public virtual User UseridFkNavigation { get; set; }
    }
}
