using System;


namespace CSharpVoidMethodConsoleApp
{
    public class ModifierClass
    {

        public void VoidMethodCalc(int numOne, int numTwo)
        {

            numOne = 32 * numOne;

                Console.WriteLine("Surprise it was " + numTwo + ", your second number!");
                Console.WriteLine();
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
        }
    }
}