using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EmployeesTimeKeepingSystem

{
   
    class Program
    {
        static void Main(string[] args)
        {
     
            // var date01 = new DateTime (2021, 8, 21, 13, 9, 52);
            //  Console.WriteLine(date01);


              var date02 = DateTime.Now;
        Console.WriteLine(date02.ToLongDateString());
            Console.WriteLine("\n");
            

            Console.WriteLine("                                             EMPLOYEES IDENTIFICATION DATA                   ");
            //Console.ReadKey();
            //string em  = Console.ReadLine();

           

         Console.Write("\nEnter Employee ID: ");
            string nums = Console.ReadLine();
           double price = Convert.ToDouble(nums);



            Console.Write("\nEnter Last Name: ");
            string last = Console.ReadLine();


            Console.Write("\nEnter First Name: ");
            string first = Console.ReadLine();


            Console.Write("\nEnter Department: ");
            string depart = Console.ReadLine();
            Console.WriteLine();

            Console.Write("\nEnter Time In (am/pm required): ");
            string timein = Console.ReadLine();




            Console.WriteLine("\n                                                   Employee ID: " + nums);

             
            Console.WriteLine("\n                                                   Employee Last Name: " + last);


            Console.WriteLine("\n                                                   Employee First Name: " + first);


            Console.WriteLine ("\n                                                   Employee Department: " + depart);

            //Console.ReadKey();
            Console.WriteLine();


            Console.Write("\nEnter Time Out (am/pm required): ");
            string timeout = Console.ReadLine();
            Console.WriteLine();

      
            string[] data = { "Time In :" + timein, "Time Out:" + timeout };

            foreach (string i in data)

            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            bool confirmed = false;
            string Key;
            do
            {
                Console.Write("TAP any key to search!: ");
                Key = Console.ReadLine();
                Console.WriteLine("\nYou entered, " + Key + " as your login key!");

                ConsoleKey response;
                do
                {
                    Console.Write("Are you want to SEARCH ?? [y/n] ");
                    response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                    if (response != ConsoleKey.End )
                        Console.WriteLine();

                    
                } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                confirmed = response == ConsoleKey.Y;
            } while (!confirmed);
            Console.WriteLine("", Key);


            string[] employeesss = {"Castillo", "Blanco", "Aganan", "Asijan" };
           
            Console.Write("\n                                                Enter Employees LAST Name: ");
            string empname = Console.ReadLine();

            bool contains = false;

                for (int i = 0; i < employeesss.Length; i++)
            {

                      if (empname  == employeesss [i])
                {

                    contains = true;
                      Console.WriteLine("\n                                                The Employee Have Schedule Today!!");

                }

                else
                {
                    

                }

            }

                if (contains ==true)

            {

               // Console.WriteLine("                           The Employee Have Schedule Today !!!!!!!!!!");

            }
          
                else
            {
                
                Console.WriteLine("\n                                            The Employee is NOT scheduled TODAY!!");

            }

          
            Console.WriteLine();
            Console.WriteLine();

             
            Console.WriteLine("                                                 WARNING : List of Morning Shift !!");

            //List<string> employees; employees = new List<string>();
            var employees = new List<string>();
            employees.Add("\n                                                           Jhyzel");
            employees.Add("\n                                                           Joan");
            employees.Add("\n                                                           Liezl");
            employees.Add("\n                                                           Jhona");
            employees.Add("\n                                                           Ariel");
            employees.Add("\n                                                           Nherjohn");

           

            var employeess = new List<string>() { "Jhyzel", "Joan", "Liezl", "Jhona", "Ariel", "Nherjohn" };
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]);
            Console.WriteLine(employees[3]);
            Console.WriteLine(employees[4]);
            Console.WriteLine(employees[5]);

       Console.WriteLine("\n                                                  WARNING : List of Night Shift !!");

            
            var applicant = new List<string>();
            applicant.Add("\n                                                           Aliyah");
            applicant.Add("\n                                                           Hannah");
            applicant.Add("\n                                                           Judea");
            applicant.Add("\n                                                           Jerrica");
            applicant.Add("\n                                                           Elton");
            applicant.Add("\n                                                           Erika");

            Console.WriteLine();

            var applicants = new List<string>() { "Aliyah", "Hannah", "Judea", "Jerrica", "Elton", "Erika" };
            Console.WriteLine(applicant[0]);
            Console.WriteLine(applicant[1]);
            Console.WriteLine(applicant[2]);
            Console.WriteLine(applicant[3]);
            Console.WriteLine(applicant[4]);
            Console.WriteLine(applicant[5]);
            Console.WriteLine();
        }

       

        }

    }

