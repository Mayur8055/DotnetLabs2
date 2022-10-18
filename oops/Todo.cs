using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Todo
    {
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }

        private Todo[] _todos = new Todo[10];

        public void ViewTodos()
        {
            foreach (var singleTodo in _todos)
            {
                if (singleTodo != null)
                {
                    Console.WriteLine("Name : " + singleTodo.Name + " | " + "Started on: " + singleTodo.Startdate + "|" + " Ends on :" + singleTodo.EndDate + "| Is Completed :" + singleTodo.IsCompleted);
                }
            }
        }
        public void ViewTodos(string pName)
        {
            foreach (var singleTodo in _todos)
            {
          
                    if (singleTodo.Name == pName) {

                    Console.WriteLine("Name : " + singleTodo.Name + " | " + "Started on: " + singleTodo.Startdate + "|" + " Ends on :" + singleTodo.EndDate + "| Is Completed :" + singleTodo.IsCompleted);
                    break;
                     }
                
            }
         }
        //User should specify where to add the new todo item in todo array
        public void Create(int pPosition)
        {
            if (pPosition > 9)
            {
                throw new Exception("Please enter a value between 0-9");

            }
            _todos[pPosition] = new Todo { Name = this.Name, Startdate = this.Startdate, EndDate = this.EndDate, IsCompleted = this.IsCompleted  };
            Console.WriteLine("Todo Created successfully");
        }
        public void Edit()
        {

        }
        public void Delete()
        {

        }

    }
}
