using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public class CharityDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CHARITYNAME { get; set; }
        public decimal Charityid { get; set; }
        public decimal? CategoryidFk { get; set; }
        public decimal? UseridFk { get; set; }
        public string Imagepath { get; set; }
        public decimal? Goal { get; set; }
        public string Email { get; set; }
        public decimal? Numdonation { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Isaccepted { get; set; }
        public decimal? State { get; set; }

    }
}
