using System;
using System.Runtime.InteropServices;
using System.Text;

namespace MemeSlider.ConsoleApplication.View
{

    /// <summary>
    /// Класс описывает рисовалку в консоли
    /// </summary>
    internal static class ConsoleView
    {
        
        internal static void HelloFromConsole() => Console.WriteLine("Hello from .NET Core MemeSlider!");
        
        internal static void SearchInfoAboutMemeFromConsole(string userInputMemeName) => Console.WriteLine($"You wanted to see a meme: {userInputMemeName}");

        internal static void ViewMemeInConsole(string memeView) => Console.WriteLine($"{memeView}");

        internal static void ErrorFindMemeFromConsole(string userInputMemeName) => Console.WriteLine($"Sorry but your meme: {userInputMemeName} not found :(");

        internal static void GetEnvironmentInfo()
        {
            Console.WriteLine($"Current Environment:");
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Console.WriteLine(RuntimeInformation.OSDescription);
        }
        
        internal static void ByeByeFromConsole() => Console.WriteLine("Bye Bye Meme Lover!");

    }
}