using MemeSlider.ConsoleApplication.Contracts;

namespace MemeSlider.ConsoleApplication.Models
{
    internal sealed class SurprisedCatMemas : IMemas
    {
        public string ConcreteMemasName { get; private set; }

        public string ConcreteMemasView { get; private set; }

        public SurprisedCatMemas()
        {
            this.ConcreteMemasName = "SurprisedCat";

            this.ConcreteMemasView =
                @"
                  　　　　／＞　 フ
　               　　　　| 　0 0 |
　                　　　／`ミ _x 彡
　               　 　 /　　　 　 |
　               　　 /　 ヽ　　 ﾉ
　               ／￣|　　 |　|　|
　               | (￣ヽ＿_ヽ_)_)
　               ＼二つ
                ";
        }

    }
}