using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Core.Extensions
{
    public static class StringExtensions
    {
        public static bool NullCheck(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }
            return false;
        }
    }
}
