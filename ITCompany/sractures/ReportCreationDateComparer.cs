using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.sractures
{
    public class ReportCreationDateComparer:IComparer
    {
        public int Compare(object x, object y)
        {
            Report t1 = (Report)x;
            Report t2 = (Report)y;
            return DateTime.Compare(t1.Creation_date, t2.Creation_date);
        }
    }
}
