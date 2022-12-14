using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class ExtensionClassForString
    {
        public static string MakeStringToUpperCase(this string name)
        {
            return name.ToUpper();
        }
    }
}
