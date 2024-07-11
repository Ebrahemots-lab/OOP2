using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Enums
{
    [Flags]
    internal enum Levels
    {
        None = 0,
        Gest = 1,
        Devloper = 2 ,
        Secretary = 4 ,
        Dba = 8
    }
}
