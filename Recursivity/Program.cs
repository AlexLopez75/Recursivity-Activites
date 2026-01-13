using System.Net.NetworkInformation;
using RecursivityLibrary;
namespace Recursivity
{
    public class Program
    {
        public static void Main()
        {
            RecursLibrary.Countdown(4);
            Console.WriteLine(RecursLibrary.CountDigits(120));
            Console.WriteLine(RecursLibrary.AddDigits(123));
            Console.WriteLine(RecursLibrary.Swap(1234));
        }
    }
}