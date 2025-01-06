using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string str,int count)
        {
            if (str.Length <= count)
            {
                return str;
            }
            else
            {
                return str.Substring(0, count) + "...";
            }

        }
    }
}
