using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommForStudent.Models
{
    public class Communittee
    {
        public int CommunitteeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}