using System;
using System.Collections.Generic;
using MemeSlider.ConsoleApplication.View;
using MemeSlider.ConsoleApplication.Models;
using MemeSlider.ConsoleApplication.Contracts;

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

            var inputMemeName = ValidateUserInput(args);

            ConsoleView.SearchInfoAboutMemeFromConsole(inputMemeName);

            if (IsMemeInContainer(inputMemeName))
            {
                var memeForView = _memasContainer[inputMemeName];
                ConsoleView.ViewMemeInConsole(memeForView);
            }
            else
            {
                ConsoleView.ErrorFindMemeFromConsole(inputMemeName);
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
                new PokerFaceMemas(),
                new OldSkullMemas(),
                new RussianBearMemas()
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

        static string ValidateUserInput(string[] argumentsFromConsole)
            => String.Join("", argumentsFromConsole).ToLower();

        static bool IsMemeInContainer(string userMemeName)
            => _memasContainer.ContainsKey(userMemeName);

        #endregion

    }
}