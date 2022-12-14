using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodWirhCustomClassExample
{
    internal class MainClassForCustomClass
    {
        static void Main(string[] args)
        {
            StudentClass studentClass = new StudentClass();
            Console.Write("Please enter your name : ");
            string username = Console.ReadLine();
            Console.WriteLine();

            studentClass.name = username;

            Console.WriteLine("User inputed the name as " + studentClass.GetName());
            Console.WriteLine("User name in upper case is " + studentClass.GetUpperCaseOftheString());
            Console.ReadLine();
        }
    }
}
