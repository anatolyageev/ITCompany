using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany.domen
{
   public enum TaskStatus:byte
    {
        
        completed, set, pending, canceled, suspended, resumed,
        delegated
    }
}
