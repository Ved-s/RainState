using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RainState
{
    public static class Extensions
    {
        public static string ConstrainLength(this string str, int length, int onExceedLength = 0)
        {
            if (str is null || str.Length <= length || length < 3 || str.Length < onExceedLength)
                return str!;

            return string.Concat(str.AsSpan(0, length - 3), "...");
        }
    }
}
