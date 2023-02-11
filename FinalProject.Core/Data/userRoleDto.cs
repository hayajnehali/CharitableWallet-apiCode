using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Data
{
    public class userRoleDto
    {
        public decimal Userid { get; set; }
        public string Email { get; set; }
        public string requestMoney { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Phonenumber { get; set; }
        public string Imagepath { get; set; }
        public decimal? Isaccepted { get; set; }
        public string Rolename { get; set; }

    }
}
