using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpClassLib
{
    public class Employee :Person
    {
        public int EmpID = 1001;

        public int Salary = 40000;

        public void salary()
        {
            Console.WriteLine("the salary of employee "+Name+" is " + Salary);
        }
        public void employeeID()
        {
            Console.WriteLine("The employee Id of " + Name + "is "+EmpID);
        }
    }

}
