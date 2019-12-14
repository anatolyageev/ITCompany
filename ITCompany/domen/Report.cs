using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    internal class Report
    {
        public Employee Owner { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Creation_date { get; set; }
        public string Report_type { get; set; }
    }
}
