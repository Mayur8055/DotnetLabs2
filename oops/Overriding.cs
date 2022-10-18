using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Parent
    {
        public virtual void ChooseCareer()
        {
            Console.WriteLine("Take Admission for BE Textile");
        }
        public void NoNightOut()
        {
            Console.WriteLine("Nightouts not allowed");
        }
    }
    public class Child:Parent
    {
        public override void ChooseCareer()
        {
            Console.WriteLine("I will choose to become a Lawyer");
        }
        public void NoNightouts()
        {
            Console.WriteLine("will go for weekly nightouts!!");
        }
    }
}
