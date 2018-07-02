using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Alex";
            //int age = 13;
            //Console.WriteLine("My First Name is..." + firstName + "And my age is" + age);

            //int a = 5;
            //int b = 7;
            //int c = a + b + 6 + 3 + 8;
            //Console.WriteLine(c);

            //string myAge;
            //Console.WriteLine("How old are you? Please enter your age.");
            //myAge = Console.ReadLine();
            //int age;
            //age = Convert.ToInt32(myAge);

            //if (age <= 16)
            //{
            //    Console.WriteLine("You cannot drive");
            //}
            //else
            //{
            //    Console.WriteLine("You can drive");
            //}


            int i = 999999999;

            do
            {
                Console.WriteLine("the value of i = " + i);
                i--;
            } while (i >= 0); // Substitution for while (i >= 0) { ... } (do while loop vs while loop)


            // Java vs C++

            // C++:
                // Allows global vars (could cause mem leak)
                // Not updated (same C++ as 20 years ago)
                // Compiles to machine lang

            // Java
                // No global vars
                // "Garbage collector" (anti mem leak) in JVM execution env
                // Compiles to byte code, isolated in JVM (thus faster than C++)
                // Slow for web services
                // i n s e c u r e
                // Has dependencies
                // Compiles code to ML only when need (JIT) - like .NET 

        }
    }
}
