﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    interface IStorable<T>
    {
        void Save();
        T Restore();
    }
}
