using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder res = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                res.Append(sb[i]);
            }

            return res;
        }
    }
}
