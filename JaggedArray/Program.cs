using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int noc, nos;
            //Console.WriteLine("Enter number of Classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string[noc][];
            //for(int i = 0; i < noc; i++) 
            //{
            //Console.WriteLine("Enter number of students in class "+(i+1));
            //    nos= int.Parse(Console.ReadLine());
            //    students[i]=new string[nos];
            //    for( int j = 0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student {j + 1}\'s name");
            //        students[i][j] = Console.ReadLine();

            //    }
            //}
            //for(int i=0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Students List of Class {i+1}");
            //    Console.WriteLine("********************************");
            //    for (int j = 0;j < students[i].Length; j++) 
            //    {
            //        Console.WriteLine(students[i][j]);
            //    }
            //    Console.WriteLine("**********************************");
            //}
            //Console.ReadLine();



            Console.Write("Enter the number of employees: ");
            int numEmployees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of working days for each employee: ");
            int numDays = Convert.ToInt32(Console.ReadLine());
            int[][] salaries = new int[numEmployees][];
            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numDays];

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Enter salary for Employee {i + 1}, Day {j + 1}: ");
                    salaries[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nDay1\tDay2\tDay3\tDay4\tDay5\tTotalSalary");
            for (int i = 0; i < numEmployees; i++)
            {
                int totalSalary = 0;

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"{salaries[i][j]}\t");
                    totalSalary += salaries[i][j];
                }

                Console.WriteLine(totalSalary);
            }

            Console.ReadKey();
        }
    }
}
