using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.sractures
{
    class Meeting
    {
        public Employee Organizer { get; set; }
        public Employee[] ListAtend { get; set; }
        public string MeetingThem { get; set; }
        public DateTime TimeOfMeeting { get; set; }
        public string MeningOfMeeting { get; set; }
    }
}
