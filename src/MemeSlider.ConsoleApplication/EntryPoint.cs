using System;
using System.Collections.Generic;
using MemeSlider.ConsoleApplication.View;
using MemeSlider.ConsoleApplication.Models;
using MemeSlider.ConsoleApplication.Contracts;
using System.Linq;

namespace MemeSlider.ConsoleApplication
{
    class EntryPoint
    {
        private static List<IMemas> _memasDependenciesList;
        private static Dictionary<string,string> _memasContainer;

        static void Main(string[] args)
        {

            MemaseInjection();
            FillMemeContainer();

            ConsoleView.HelloFromConsole();
            ConsoleView.ShowAllMemeNamesInApp();

            ShowAllMemeNames();

            var inputMemeName = ValidateUserInput(args);
            var isUserWantExitFlag = false;

            while (!isUserWantExitFlag)
            {
                ConsoleView.NormalizeConsole();

                ConsoleView.SearchInfoAboutMemeFromConsole(inputMemeName);

                if (IsMemeInContainer(inputMemeName))
                {
                    var memeForView = _memasContainer[inputMemeName];
                    ConsoleView.ViewMemeInConsole(memeForView);
                }
                else
                {
                    ConsoleView.DrawDanger();
                    ConsoleView.ErrorFindMemeFromConsole(inputMemeName);
                }

                ConsoleView.AskToContinue();

                if (String.Compare(ConsoleView.ReadConsoleUserInput().ToLower(), "n") == 0)
                {
                    isUserWantExitFlag = true;
                }
                else
                {
                    Console.WriteLine("Please insert Meme Name:");

                    var newInput = ConsoleView.ReadConsoleUserInput();
                    inputMemeName = ValidateUserInput(newInput);
                }

            }

            ConsoleView.GetEnvironmentInfo();
            ConsoleView.ByeByeFromConsole();

        }

        #region Private Methods

        static void MemaseInjection()
            =>
            _memasDependenciesList = new List<IMemas>()
            {
                new DogeMemas(),
                new NyanCatMemas(),
                new OldSkullMemas(),
                new PokerFaceMemas(),                
                new RussianBearMemas(),
                new SurprisedCatMemas(),
                new WallMemas()
            };

        static void FillMemeContainer()
        {
            _memasContainer = new Dictionary<string, string>();

            _memasDependenciesList
                .ForEach(x =>
                {
                    var lowerMemosName = x.ConcreteMemasName.ToLower();
                    _memasContainer.Add(lowerMemosName, x.ConcreteMemasView);
                }
                );
        }

        static void ShowAllMemeNames()
        {
            _memasDependenciesList
                .ForEach(x =>
                {
                    ConsoleView.ViewMemeNameInConsole(x.ConcreteMemasName);
                }
                );
        }

        static string ValidateUserInput(string[] argumentsFromConsole)
            => String.Join("", argumentsFromConsole).ToLower();

        static string ValidateUserInput(string inputFromUser)
            => new string(
                    inputFromUser
                        .ToCharArray()
                            .Where(ch => !Char.IsWhiteSpace(ch))
                                .ToArray()
                ).ToLower();

        static bool IsMemeInContainer(string userMemeName)
            => _memasContainer.ContainsKey(userMemeName);

        #endregion

    }
}