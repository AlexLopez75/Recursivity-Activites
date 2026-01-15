using RecursivityLibrary;
using System.Collections;
using System.Net.NetworkInformation;
namespace Recursivity
{
    public class Program
    {
        public static void Main()
        {
            int[] arrayInt = { 3, 2, 4, 1, 5 };

            RecursLibrary.Countdown(4);
            Console.WriteLine(RecursLibrary.CountDigits(120));
            Console.WriteLine(RecursLibrary.AddDigits(123));
            Console.WriteLine(RecursLibrary.Swap(1234));
            RecursLibrary.PrintForwardArray(arrayInt, 0);
            Console.WriteLine();
            RecursLibrary.PrintBackwardArray(arrayInt, 4);
            Console.WriteLine();
            Console.WriteLine(RecursLibrary.FindMax(arrayInt, 0));
        }
    }
}