using System;

namespace EmpClassLib
{
    public class person
    {
        public string Name = "Mayur";
        public int Age = 22;
        public void name()
        {
            Console.WriteLine("The name of the person is " + Name);
        }
        public void age()
        {
            Console.WriteLine("Age of " + Name + "is " + Age);
        }
    }
    
}