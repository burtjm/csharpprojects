using System;
using System.Collections.Generic;
using System.Text;

namespace burt_StudentApp
{
   public class Student
    {
            public int  ID;
            public string Name;
            public double[] hours = new double[7];

            public void EnterHours(int index, int yourHours)
            {
                hours[index] = yourHours;
            }

            public double[] GetNumberHours()
            {
                return hours;
            }

            public double CalculateAvg()
            {
                double num = 0;
                foreach (double number in this.hours)
                {
                    num += number;
                }
                return (num / ((double)this.hours.Length));

            }
        }

    }

