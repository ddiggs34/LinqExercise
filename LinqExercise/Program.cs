using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers - DONE
           var sumOfList = numbers.Sum();
          // Console.WriteLine(sumOfList);

            //TODO: Print the Average of numbers - DONE
            var avgOfList = numbers.Average();

            //    Console.WriteLine(avgOfList);
            

            //TODO: Order numbers in ascending order and print to the console - done
            var ascOrder = numbers.OrderBy(x => x);
            
           foreach (var number in numbers) 
           {
           //  Console.WriteLine(number);
           }

            //TODO: Order numbers in descending order and print to the console - done
            var descOrder = numbers.OrderByDescending(n => n);

            foreach (var number in descOrder)
            {
             //   Console.WriteLine(number);
            }

            //TODO: Print to the console only the numbers greater than 6 - done

            var sevenUp = numbers.Where(x => x > 6);
            foreach (var number in sevenUp)
            {
           //     Console.WriteLine(number);
            }


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!** - done

          var first4 = numbers.OrderBy(x => x).Take(4);
            
            foreach (var num in first4)
            {
         //       Console.WriteLine(num);
            }


            //TODO: Change the value at index 4 to your age, then print the numbers in descending order - done

           // Console.WriteLine("-----------CHANGE THE VALUE INDEX AT 4 ---------");
            numbers.SetValue(35, 4); // SET VALUE (index input you want to change it to, index you want replaced) - changing the 4 to 35
            
            foreach (var number in descOrder)
            { 
          //      Console.WriteLine(number); 
            }


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            
         // new list   = employeesList.FILTER (x => x.employee property (other class)
            var onlyCS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName);

            foreach (var employee in onlyCS) 
            {
               // Console.WriteLine(employee.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var twentySevenUp = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
                foreach 
                (var person in twentySevenUp)
                {
                //    Console.WriteLine($"Name - {person.FullName} || Age - {person.Age}");
                }
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            //new list = EMPLOYEES.Where filter(x => x.property YearsOfExp >= 10 && other filter condition)    
            var yrsTest = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine(yrsTest.Sum(x => x.YearsOfExperience));
            Console.WriteLine(yrsTest.Average(x => x.YearsOfExperience));







            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("David", "Diggs", 35, 0)).ToList();

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
