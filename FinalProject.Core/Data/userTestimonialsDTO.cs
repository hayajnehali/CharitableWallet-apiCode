using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public class userTestimonialsDTO
    {
        public decimal Testimonialid { get; set; }
        public decimal? UseridFk { get; set; }
        public string Paragraph { get; set; }
        public decimal? Isaccept { get; set; }
        public decimal? Rate { get; set; }
        public decimal Userid { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Phonenumber { get; set; }
        public string Imagepath { get; set; }
        public decimal? Isaccepted { get; set; }
        public decimal? RoleidFk { get; set; }
    }
}
