using System;
using System.Collections.Generic;


namespace EmployeesTimeKeepingSystem
   
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("                                             EMPLOYEES IDENTIFICATION DATA                   ");
            //Console.ReadKey();
            //string em  = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter Employee Number:");
            string num = Console.ReadLine();
            double price = Convert.ToDouble(num);


            Console.WriteLine("Enter Last Name:");
            string last = Console.ReadLine();


            Console.WriteLine("Enter First Name:");
            string first = Console.ReadLine();


            Console.WriteLine("Enter Department:");
            string depart = Console.ReadLine();

            Console.WriteLine("Enter Time In (am/pm required):");
            string timein = Console.ReadLine();

            Console.WriteLine("Enter Time Out (am/pm required):");
            string timeout = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Employee Number: " + num);


            Console.WriteLine("Employee Last Name: " + last);


            Console.WriteLine("Employee First Name: " + first);


            Console.WriteLine("Employee Department: " + depart);

            Console.ReadKey();
            Console.WriteLine();

          


            string[] data = { "Time In :" + timein, "Time Out:" + timeout };

        
            foreach (string i in data)

            {
                Console.WriteLine(i);
            }


           // Console.WriteLine("Search Information:");

            Console.WriteLine();

            Console.WriteLine("...................................     WARNING : List of Morning Shift !!...........................................");

            //List<string> employees; employees = new List<string>();
            var employees = new List<string>();
            employees.Add("Jhyzel");
            employees.Add("Joan");
            employees.Add("Liezl");
            employees.Add("Jhona");
            employees.Add("Ariel");
            employees.Add("Nherjohn");

            Console.WriteLine();

            var employeess = new List<string>() { "Jhyzel", "Joan", "Liezl", "Jhona","Ariel", "Nherjohn" };
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]); 
            Console.WriteLine(employees[3]);
            Console.WriteLine(employees[4]);
            Console.WriteLine(employees[5]);

            Console.WriteLine("...................................     WARNING : List of Night Shift !!...........................................");

            Console.WriteLine();
            var applicant = new List<string>();
            applicant.Add("Aliyah");
            applicant.Add("Hannah");
            applicant.Add("Judea");
            applicant.Add("Jerrica");
            applicant.Add("Elton");
            applicant.Add("Erika");
            
            Console.WriteLine();

            var applicants = new List<string>() { "Aliyah", "Hannah", "Judea", "Jerrica", "Elton", "Erika" };
            Console.WriteLine(applicant[0]);
            Console.WriteLine(applicant[1]);
            Console.WriteLine(applicant[2]);
            Console.WriteLine(applicant[3]);
            Console.WriteLine(applicant[4]);
            Console.WriteLine(applicant[5]);
            Console.WriteLine();
        } }

    }

