using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    // WorkItem implicitly inherits from the Object class.
    class Myclass
    {
        private string data = "Data";
        private string Data()
        {
            return data;
        }
    }
    class Program
    {


        static void Main()
        {
            Myclass cls = new Myclass();
            MethodInfo mthd = cls.GetType().GetMethod("Data", BindingFlags.NonPublic | BindingFlags.Instance);
            var data = mthd.Invoke(cls, new object[] { });
            Console.WriteLine(data);
        }
    }
    /* Output:
        1 - Fix Bugs
        2 - Change the Design of the Base Class
    */
}
