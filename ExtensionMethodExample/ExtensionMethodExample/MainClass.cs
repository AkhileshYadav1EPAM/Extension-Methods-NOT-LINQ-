using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            string name = "akhilesh kumar yadav";
            string nameInUpperCase = name.MakeStringToUpperCase();
            Console.WriteLine(name + " in upper case is - " + nameInUpperCase);

            Console.ReadLine();
        }
    }
}
