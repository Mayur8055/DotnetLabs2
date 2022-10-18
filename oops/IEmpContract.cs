using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public interface IEmpContract
    {
        int WorkHoursClause();
        string SickLeavesClause();
    }

    public class KpmgEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
       
        public string SickLeavesClause()
        {
            return "Employee is allowed to take 5 sick leaves per month";
        }

        public int WorkHoursClause()
        {
            return 8;
        }
    }


    public class DellEmployee : IEmpContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employee is allowed to take 4 sick leaves per month";
        }

        public int WorkHoursClause()
        {
            return 8;
        }
    }




    class MyClass : ParentClass, IContract1, IContract2
    {
        //MyClass can inherit only from 1 other class.It cannot inherit form multiple classes
        //BUT , It can implement multiple interfaces
        //It can also inherit from 1 class and implement multiple interfaces

    }
        internal interface IContract2
        {
        }

        internal interface IContract1
        {
        }

        internal class ParentClass
        {
        }
    
}
