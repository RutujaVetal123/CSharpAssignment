using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public string bookType;
    }
    public enum BookTypes
    {
        Magazine=0, Novel, ReferenceBook, Miscellaneous
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Calculator
            // Task 1 ************************************************************//
            /* Calculator
             * Addition
             * Subtraction
             * Multiplication
             * Division*/
            Calculator cal = new Calculator();

            Console.WriteLine("\t Calculator\n Enter Two Numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t Operations can be performend " +
                "\n 1. Addtion\n 2. Subtraction\n 3. Multiplication\n 4. Division" +
                "\n Answer : ");
            int ans = Convert.ToInt32(Console.ReadLine());
            int result;
            double div;

            switch (ans)
            {
                case 1:
                    result = cal.Addition(num1, num2);
                    Console.WriteLine("Addition = " + result);
                    break;

                case 2:
                    result = cal.Subtraction(num1, num2);
                    Console.WriteLine("Subtraction = " + result);
                    break;

                case 3:
                    result = cal.Multiplication(num1, num2);
                    Console.WriteLine("Multiplication = " + result);
                    break;

                case 4:
                    div = cal.Division(num1, num2);
                    Console.WriteLine("Division = " + div);
                    break;

                default:
                    Console.WriteLine("INVALID OPERATION");
                    break;
            }
            #endregion


            #region Highest Marks
            Console.WriteLine("\n\n************************************************************");
            // Task 2 ************************************************************//
            /*  
             *  Accept average marks of five students. Display the highest marks obtained 
             */

            int[] marks = new int[5];
            Console.WriteLine("\t Highest Marks\n Enter five Students score :");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxMarks = cal.MaxMarks(marks);
            Console.WriteLine("Highest Score = " + maxMarks);
            #endregion


            #region Sum of N integers
            Console.WriteLine("\n\n************************************************************");
            // Task 3 ************************************************************//
            /*  
             * The method should find the sum of all the integers passed and display the result. 
             */

            Console.WriteLine("\t Sum of \'n\' integer\n How many numbers do you want to add? :");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 > 0)
            {
                int[] array = new int[num3];
                Console.WriteLine("Enter the " + num3 + " integers : ");
                for (int i = 0; i < num3; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = cal.SumOfNum(array);
                Console.WriteLine("Sum of " + num3 + " integers = " + sum);
            }
            else
            {
                Console.WriteLine("INVALID NUMBER (SHOULD BE NON-ZERO AND POSITIVE)");
            }
            #endregion


            #region Swap
            Console.WriteLine("\n\n************************************************************");
            // Task 4 ************************************************************//
            /*  
             *  Method to swap two integer and print the swapped value.
             */

            Console.WriteLine("\t Swappin of numbers\n Enter Two Numbers : ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            cal.Swap(num4, num5);
            #endregion


            #region Area and Circumference of Circle
            Console.WriteLine("\n\n************************************************************");
            // Task 5 ************************************************************//
            /*  
             * Method that calculates the area and circumference of the circle. 
             */

            Console.WriteLine("\t Circumference and Area of Circle\n Enter the radius : ");
            double radius = Convert.ToInt32(Console.ReadLine());
            cal.AreaCircumOfCircle(radius);
            #endregion


            #region Book
            Console.WriteLine("\n\n************************************************************");
            // Task 6 ************************************************************//
            /*  
             * Create a structure Book
             * a. Accept the details of the book
             * b. Display the details of the book. The type of book should be displayed as a string e.g.: Magazine
             */
            Book book = new Book();
            Console.WriteLine("\tBook Details\n Enter the Book Details : \nBook ID : ");
            book.bookId=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBook Title : ");
            book.title = Console.ReadLine();
            
            Console.WriteLine("\nBook Price : ");
            book.price = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\nBook Type : \n1. Magazine\n2. Novel\n3. ReferenceBook\n4. Miscellaneous");
            int type= Convert.ToInt32(Console.ReadLine());

            book.bookType = Enum.GetName(typeof(BookTypes), type - 1);
            Console.WriteLine("\nDetails of book are: " +
                "\n/* ID: " + book.bookId +
                "\n/* Title: " + book.title + 
                "\n/* Price: " + book.price + 
                "\n/* Type: " + book.bookType);
            Console.ReadKey();

            #endregion
        }
    }
}
