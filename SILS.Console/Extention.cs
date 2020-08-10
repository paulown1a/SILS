using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Console
{
    internal static class Extention
    {
        internal static string CleanNULL(this string reader)
        {
            return reader == null ? "=" : reader;
        }


    }
}
