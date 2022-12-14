using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodWirhCustomClassExample
{
    public static class ExtensionClassForStudentClass
    {
        public static string GetUpperCaseOftheString(this StudentClass studentClass)
        {
            return studentClass.name.ToUpper();
        }
    }
}
