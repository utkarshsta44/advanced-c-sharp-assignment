using System;
delegate void MyDelegate(string message);

namespace assignment_advanced_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:
           
            /*try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[3]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException occurred: " + e.Message);
            }
            */






            //question 2:

            /*
             try
               {
                   int[] numbers = { 1, 2, 3 };
                   Console.WriteLine(numbers[3]); // This will throw an IndexOutOfRangeException
               }
               catch (IndexOutOfRangeException e)
               {
                   Console.WriteLine("IndexOutOfRangeException occurred: " + e.Message);
               }
               catch (DivideByZeroException e)
               {
                   Console.WriteLine("DivideByZeroException occurred: " + e.Message);
               }
               catch (Exception e)
               {
                   Console.WriteLine("Some other exception occurred: " + e.Message);

               }
            */


            //Question 3:


             MyDelegate del = new MyDelegate(PrintMessage);
             del += DisplayMessage; // Adding another method to the delegate

             del("Hello, world!"); // Calling the delegate with a message

             static void PrintMessage(string message)
             {
                 Console.WriteLine("Printing message: " + message);
             }

             static void DisplayMessage(string message)
             {
                 Console.WriteLine("Displaying message: " + message);
             }
            



            //Questin 4:


            /*
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3)); // Output: 5

            Action<string> greet = name => Console.WriteLine("Hello, " + name);
            greet("Utkarsh"); // Output: Hello, Alice

            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven(4)); // Output: True
            */

            // Question 6:


            /* Process1();

             Process2();
            

            static void Process1()
            {
                Console.WriteLine("Process 1 Started");

         
                System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

                Console.WriteLine("Process  1 Completed");
            }

            static void Process2()
            {
                Console.WriteLine("Process 2 Started");

             

                Console.WriteLine("Process  2 Completed");
            }
            */
        }
    }
}