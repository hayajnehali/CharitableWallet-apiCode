using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class Contactu
    {
        public decimal Contactid { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Msg { get; set; }
        public string Phonenumber { get; set; }
    }
}
