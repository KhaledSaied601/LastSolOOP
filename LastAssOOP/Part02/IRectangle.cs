using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part02
{
    internal interface IRectangle:IShape
    {
    }
    internal class Rectangle : IRectangle
    {
        public decimal Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Area : {Area}");
        }
    }
}
