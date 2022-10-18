// See https://aka.ms/new-console-template for more information
using System;
using EmpClassLib;

class Program
{
    static void Main(string[] args)
    {
        /*
            Employee emp1 = new Employee();
            emp1.name();
            emp1.employeeID();
            emp1.age();
            emp1.salary();

     }*/

        Console.WriteLine("--parent p = new Child()--");
        //Base class  = new DerivedClass()
        Person Loo = new Employee();
        Loo.takeLeave();
        Loo.PlayAllowed();


        Console.WriteLine("--Child ch = new Child()--");
        Employee nxgenChild = new Employee();
        nxgenChild.NoPlayAllowed();
    }  
}




