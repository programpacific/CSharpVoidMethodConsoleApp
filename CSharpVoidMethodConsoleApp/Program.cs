using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
// 1. Create a class. In that class, create a void method that takes two integers as parameters.
// Have the method do a math operation on the first integer and display the second integer to the screen.
// 2. In the Main() method of the console app, instantiate the class.
// 3. Call the method in the class, passing in two numbers.
// 4. Call the method in the class, specifying the parameters by name.


namespace CSharpVoidMethodConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Void Method Demonstration Application");
            Console.WriteLine("Void methods do NOT return traditionally!");
            Console.WriteLine();
            Console.WriteLine("We'll first insert two integers, do a math operation on one of them and display the integer to the screen.");
            Console.WriteLine();
            Console.WriteLine("Who knows what number you'll get back!");
            Console.WriteLine();

            ModifierClass modifierClass = new ModifierClass();

            Console.WriteLine("What is the first integer you'd like to input?");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("What is the second integer you'd like to input?"));
            int numTwo = Convert.ToInt32(Console.ReadLine());

            modifierClass.VoidMethodCalc(numOne, numTwo);
        }
    }
}

// So this fills the requirements, but couldn't think of anything much fun to do with it! &&& Who's to say that I didn't totally understand the intent of the exercise!
// Thanks again for your guy's help, it is starting to click!