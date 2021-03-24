using CSharpLanguageFeatures.CSharpSeven;
using System;
using System.Threading.Tasks;

namespace CSharpConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(LocalFunctions.InternalVariables());
        }

        // Async main is a C# 7.1 language feature that allows you to use await in the Main method
        ////public static async Task Main(string[] args)
        ////{
        ////    Console.WriteLine("Starting!");

        ////    for (int i = 1; i < 6; i++)
        ////    {
        ////        await Task.Delay(1000);
        ////        Console.WriteLine($"...waiting for {i} second(s)");
        ////    }

        ////    Console.WriteLine("This is an async main!");
        ////}
    }
}
