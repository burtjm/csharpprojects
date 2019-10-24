using System;
using System.Collections.Generic;
using System.Text;

namespace burt_StudentApp
{
    public class StudentUI
    {
        int yourHours;
        private string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public void MainMethod()
        {
            Student student = new Student();
            Console.WriteLine("Enter Your Name:\t ");
            student.Name = Console.ReadLine();

           
            

            int num1;
            while (true)
            {
                Console.WriteLine("Enter Your ID Number:\t ");
                
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
                student.ID = int.Parse(Console.ReadLine());
            }
            

            FillHours(student);
            this.DisplayData(student);
            this.DisplayAverage(student);
        }

        public void FillHours(Student student)
        {
            for (int i = 0; i < days.Length; i++)
            {
                
                    Console.Write("How many hours did you study on {0}?: ", days[i]);
                
                    yourHours = int.Parse(Console.ReadLine());
                    student.EnterHours(i, yourHours);
                }
            }
        

    public void DisplayAverage(Student student)
        {
            Console.Write("\nHere's your weekly average: " + student.CalculateAvg());


        }

        public void DisplayData(Student student)
        {
            double[] numHours = new double[this.days.Length];
            Console.Clear();
            Console.WriteLine("Name: {0}", student.Name);
            Console.WriteLine("ID: {0}", student.ID);
            Console.WriteLine("Daily Hours:");
            numHours = student.GetNumberHours();
            for (int i = 0; i < this.days.Length; i++)
            {
                Console.Write("\t{0}:", this.days[i]);
                Console.WriteLine("\t{0:N2}", numHours[i]);
            }
        }
    }
}

