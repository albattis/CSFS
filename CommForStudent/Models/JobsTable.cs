using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommForStudent.Models
{
    public class JobsTable
    {
        public int Id { get; set; }
        public string JobsName { get; set; }
        public string JobsDescription { get; set; }
        public int CommunitteeId { get; set; }
    }
}