using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part02
{
    internal interface IShape
    {
        public decimal Area { get; set; }

        
        public void DisplayShapeInfo();
    }
}
