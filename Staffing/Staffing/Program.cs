using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staffing
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void DoSomthing()
        {
            Console.WriteLine("I'm doing something now!");
        }
        static void Feature()
        {
            Console.WriteLine("Feature 01 has been implemented!");
        }
        static void ExternalAccess()
        {
            //added by external user.
            Console.Write("Please enter your key:");
            var keyedin = Console.ReadLine();
            Console.WriteLine("You keyed in: {0}", keyedin);
        }
        static void DoFeature()
        {
            Console.WriteLine("Feature is done!");
        }
        static void DoFeature2()
        {
            Console.WriteLine("Feature is done!");
        }
    }
}
