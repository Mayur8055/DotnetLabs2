using System;
using System.Collections.Generic;
class Program {
    static void Main()
    {
        List<string> strList = new List<string>();
        strList.Add("Apples");
        strList.Add("Oranges");
        strList[1] = "Lemons";

        foreach (var singleItem in strList)
        {
            Console.WriteLine(singleItem);
        }

        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { ID = 1001, Name = "Mayur" });
        employees.Add(new Employee() { ID = 1002, Name = "Preetham" });
        foreach (var person in employees)
        {
            Console.WriteLine(person.Name + "-" + person.ID);
        }
    }
}

internal class Employee
{
    public Employee()
    {

    }

    public int ID { get; set; }
    public string Name { get; set; }
}