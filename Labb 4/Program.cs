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

            Console.WriteLine("Retrive Items using for each ");

            

            foreach (Employee E in MyStack)
            {
                Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3} ", E.ID, E.Name, E.Gender, E.Salary);
                int count = MyStack.Count;
                Console.WriteLine("Items left in the stack = {0} ", count);

            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrive Items using Pop Method");



            Employee employeeFromMyStack = MyStack.Pop();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3} ", employeeFromMyStack.ID, employeeFromMyStack.Name, employeeFromMyStack.Gender, employeeFromMyStack.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack2 = MyStack.Pop();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeeFromMyStack2.ID, employeeFromMyStack2.Name, employeeFromMyStack2.Gender, employeeFromMyStack2.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack3 = MyStack.Pop();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeeFromMyStack3.ID, employeeFromMyStack3.Name, employeeFromMyStack3.Gender, employeeFromMyStack3.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack4 = MyStack.Pop();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeeFromMyStack4.ID, employeeFromMyStack4.Name, employeeFromMyStack4.Gender, employeeFromMyStack4.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeeFromMyStack5 = MyStack.Pop();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeeFromMyStack5.ID, employeeFromMyStack5.Name, employeeFromMyStack5.Gender, employeeFromMyStack5.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Console.WriteLine("----------------------------");

            MyStack.Push(E1);
            MyStack.Push(E2);
            MyStack.Push(E3);
            MyStack.Push(E4);
            MyStack.Push(E5);


            Console.WriteLine("----------------------------");
            Console.WriteLine("Using Peek Method");

            Employee employeePeek = MyStack.Peek();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeePeek.ID, employeePeek.Name, employeePeek.Gender, employeePeek.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            Employee employeePeek2 = MyStack.Peek();
            Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", employeePeek2.ID, employeePeek2.Name, employeePeek2.Gender, employeePeek2.Salary);
            Console.WriteLine("Items left in the stack " + MyStack.Count);

            if (MyStack.Contains(E3))
            {
                Console.WriteLine("Item finns i stacken");
            }
            else
            {
                Console.WriteLine("Item finns inte i stacken");
            }

            //List

            List<Employee> EmpList = new List<Employee>();
            
                EmpList.Add(E1);
                EmpList.Add(E2);
                EmpList.Add(E3);
                EmpList.Add(E4);
                EmpList.Add(E5);

            

            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list");
            }
            Console.WriteLine("----------------------------");

            // Find 
            Employee FindMale = EmpList.Find(x=> x.Gender == "Male");
            
                Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", FindMale.ID, FindMale.Name, FindMale.Gender, FindMale.Salary);

            Console.WriteLine("-----------");

            List<Employee> FindAllMale = EmpList.FindAll(x => x.Gender == "Male");

            foreach (Employee Item in FindAllMale)
            {
                Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary {3}", Item.ID, Item.Name, Item.Gender, Item.Salary);
            }



            Console.ReadKey();
        }

    }
}
