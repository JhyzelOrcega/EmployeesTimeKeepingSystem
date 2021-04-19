using System;

namespace EmployeesTimeKeepingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Number:"); 
            string num = Console.ReadLine();
          

            Console.WriteLine("Enter Last Name:");
            string last = Console.ReadLine();
            

            Console.WriteLine("Enter First Name:");
            string first = Console.ReadLine();
          

            Console.WriteLine("Enter Department:");
            string depart = Console.ReadLine();
         //   Console.ReadKey();

      

            Console.WriteLine("Employee Number: " + num);
           

            Console.WriteLine("Employee Number: " + last);
       

            Console.WriteLine("Employee Number: " + first);
            

            Console.WriteLine("Employee Number: " + depart);
            Console.ReadKey();


        }
    }
}
