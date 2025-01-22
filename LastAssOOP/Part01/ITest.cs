using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part01
{
    public interface ITest : Interface1
    {

        string TestName { get; }

        static void TestMethod()
        {
            Console.WriteLine("Hello Test");
        }

        static ITest()
        {
            Console.WriteLine("Hi ITEST Constructor");


        }


    }
}
