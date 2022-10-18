using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassLib
{
    /*
    public abstract class Person
    {
         public string Name = "Mayur";
         public int Age = 22;
         public void name()
         {
             Console.WriteLine("The name of the person is " + Name);
         }
         public void age()
         { 
             Console.WriteLine("Age of " + Name + " is " + Age);
         }
         public abstract void height();
   }
 */


    public class Person
    {
        public virtual void takeLeave()
        {
            Console.WriteLine("Take Leave on monday");
        }
        public void PlayAllowed()
        {
            Console.WriteLine(" playing allowed");
        }
    }
    public class Employee : Person
    {
        public override void takeLeave()
        {
            Console.WriteLine("Take leave on Tuesday");
        }
        public void NoPlayAllowed()
        {
            Console.WriteLine("playing is not allowed!!");
        }
    }



}
