using System;
using System.Collections.Generic;

namespace Labb_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee()
            {
                ID = 123,
                Name = "Mattias",
                Gender = "Male",
                Salary = 10000,


            };

            Employee E2 = new Employee()
            {
                ID = 124,
                Name = "Markus",
                Gender = "Male",
                Salary = 20000,
            };

            Employee E3 = new Employee()
            {
                ID = 234,
                Name = "Anna",
                Gender = "Female",
                Salary = 24000,

            };

            Employee E4 = new Employee()
            {
                ID = 101,
                Name = "Towe",
                Gender = "Female",
                Salary = 34000,
            };


            Employee E5 = new Employee()
            {
                ID = 117,
                Name = "Jonas",
                Gender = "Male",
                Salary = 34000,
            };

            Stack<Employee> MyStack = new Stack<Employee>();
            MyStack.Push(E1);
            MyStack.Push(E2);
            MyStack.Push(E3);
            MyStack.Push(E4);
            MyStack.Push(E5);

            foreach (Employee E in MyStack)
            {
                Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3} ", E.ID, E.Name, E.Gender, E.Salary);
                int count = MyStack.Count;
                Console.WriteLine("Items left in the stack = {0} ", count);
            }

            Employee employeeFromMyStack = MyStack.Pop();
            Console.WriteLine("ID : {0} , Name : {1} ", employeeFromMyStack.ID, employeeFromMyStack.Name, employeeFromMyStack.Gender, employeeFromMyStack.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack2 = MyStack.Pop();
            Console.WriteLine("ID : {0} , Name : {1} ", employeeFromMyStack.ID, employeeFromMyStack.Name, employeeFromMyStack.Gender, employeeFromMyStack.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack3 = MyStack.Pop();
            Console.WriteLine("ID : {0} , Name : {1} ", employeeFromMyStack.ID, employeeFromMyStack.Name, employeeFromMyStack.Gender, employeeFromMyStack.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);



            Console.ReadKey();
        }
    }
}
