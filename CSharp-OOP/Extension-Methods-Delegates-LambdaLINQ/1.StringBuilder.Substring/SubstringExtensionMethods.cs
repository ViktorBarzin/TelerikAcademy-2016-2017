using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MyStringBuilder.Substring
{
    public static class SubstringExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder stringbuilder, int start, int count)
        {
            return new StringBuilder(stringbuilder.ToString().Substring(start, count));
        }

        public static StringBuilder Substring(this StringBuilder stringbuilder, int start)
        {
            return new StringBuilder(stringbuilder.ToString().Substring(start));
        }
    }
}
