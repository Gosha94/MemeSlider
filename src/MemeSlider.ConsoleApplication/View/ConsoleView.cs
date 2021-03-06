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

        internal static void NormalizeConsole()
        {            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        internal static void ClearConsole()
            => Console.Clear();

        internal static void HelloFromConsole() => Console.WriteLine("Hello from .NET Core MemeSlider!");

        internal static void ShowAllMemeNamesInApp() => Console.WriteLine("Below is a list of all the memes in the application:");

        internal static void SearchInfoAboutMemeFromConsole(string userInputMemeName) => Console.WriteLine($"You wanted to see a meme: {userInputMemeName}");

        internal static void ViewMemeNameInConsole(string memeName) => Console.WriteLine($"{memeName}");

        internal static void ViewMemeInConsole(string memeView) => Console.WriteLine($"{memeView}");

        internal static void ErrorFindMemeFromConsole(string userInputMemeName) 
        {
            Console.WriteLine($"Sorry but your meme: {userInputMemeName} not found :(");
        }

        internal static void DrawDanger() => Console.ForegroundColor = ConsoleColor.Red;

        internal static void GetEnvironmentInfo()
        {
            Console.WriteLine($"Current Environment:");
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Console.WriteLine(RuntimeInformation.OSDescription);
        }

        internal static string ReadConsoleUserInput() => Console.ReadLine();

        internal static void AskToContinue() => Console.WriteLine("Are You want another meme?\n[Y,N]: ");

        internal static void ByeByeFromConsole() => Console.WriteLine("Bye Bye Meme Lover!");

    }
}