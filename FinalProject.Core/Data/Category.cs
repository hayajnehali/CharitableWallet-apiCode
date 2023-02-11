using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.Core.Data
{
    public partial class Category
    {
        public Category()
        {
            Cahrities = new HashSet<Cahrity>();
        }

        public decimal Categoryid { get; set; }
        public string Categoryname { get; set; }
        public string Categoryimage { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryParagraph { get; set; }

        public virtual ICollection<Cahrity> Cahrities { get; set; }
    }
}
