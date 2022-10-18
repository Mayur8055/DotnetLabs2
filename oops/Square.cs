using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Square : Rectangle
    {
        public string Name { get; set; }
       
        public Square(float pSide) :base(pSide, pSide)
        {

        }
    }
}
