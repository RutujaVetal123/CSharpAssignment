using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    class Calculator
    {
        #region Calculator
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public double Division(int a, int b)
        {
            return a / b;
        }
        #endregion

        #region Highest marks
        public int MaxMarks(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < 5; i++)
                if (marks[i] > max)
                    max = marks[i];
            return max;
        }
        #endregion

        #region Sum of n numbers
        public int SumOfNum(int[] array)
        {
            int sum = 0;
            for (int i=0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        #endregion

        #region Swap
        public void Swap(int num4, int num5)
        {
            int temp = num4;
            num4 = num5;
            num5 = temp;
            Console.WriteLine("Swaped Numbers : "+num4+" "+num5);
        }
        #endregion

        #region Area and Circumference of Circle
        public void AreaCircumOfCircle(double radius)
        {
            double PI = Math.PI;
            double Area = PI *radius*radius;

            double Circumference = 2 * PI * radius;
            Console.WriteLine("Circle of radius "+radius+ " has Area : " + Area +" and Circumference : "+ Circumference);

        }
        #endregion
    }
}
