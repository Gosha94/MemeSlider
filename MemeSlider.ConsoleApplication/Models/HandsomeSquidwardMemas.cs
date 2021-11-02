using MemeSlider.ConsoleApplication.Contracts;

namespace MemeSlider.ConsoleApplication.Models
{

    internal sealed class HandsomeSquidwardMemas : IMemas
    {
        public string ConcreteMemasView { get; private set; }

        public string ConcreteMemasName { get; private set; }

        public HandsomeSquidwardMemas()
        {

            this.ConcreteMemasName = "HandsomeSquidward";

            this.ConcreteMemasView = 
            @"
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣀⣀⣠⣤⣤⣄⣀⣀⣀⡀
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⠤⠖⠊⠉⠁⠄⠄⠄⠄⠄⠄⠄⠄⠈⠉⠙⠲⢤⡀
                ⠄⠄⠄⠄⠄⠄⠄⡤⠊⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢦⡀
                ⠄⠄⠄⠄⠄⠄⡜⠄⠄⠄⠄⠄⠄⢀⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⢢⠄⠄⠄⠄⠄⢳
                ⠄⠄⠄⠄⠄⣸⠁⠄⠄⠄⠄⠄⠄⠄⠱⡀⠄⠄⠄⠄⠄⠄⠄⡀⠈⠄⡀⠄⠄⠄⠈⡇
                ⠄⠄⠄⠄⠄⡏⠄⠄⠄⠄⠄⠄⠄⠄⡰⠁⠄⠄⠄⠄⠄⠄⠄⠘⡆⡜⠁⠄⠄⠄⠄⢧⡀
                ⠄⠄⠄⠄⠄⡇⠄⠄⠄⠄⠄⠄⠄⠸⡀⠄⠄⠄⠄⠄⣀⣤⡂⠄⠇⠱⠄⡀⠄⠄⠄⠄⡇
                ⠄⠄⠄⠄⠄⢇⠄⠄⠄⠄⠄⠄⠄⠄⠈⢄⡀⢠⣟⢭⣥⣤⠽⡆⠄⡶⣊⣉⣲⣤⢀⡞
                ⠄⠄⠄⠄⠄⠘⣆⠄⠄⠄⠄⠄⠄⡀⠄⠐⠂⠘⠄⣈⣙⡡⡴⠄⠄⠙⣄⠙⣛⠜⠘⣆
                ⠄⠄⠄⠄⠄⠄⠈⢦⡀⠄⠄⠄⢸⠁⠄⠄⠄⠄⠄⠄⠄⠊⠄⠄⠄⠄⡸⠛⠄⠄⠄⢸
                ⠄⠄⠄⠄⠄⠄⠄⠄⠈⠓⠦⢄⣘⣄⠄⠄⠄⠄⠄⠄⠄⡠⠄⠄⠄⠄⣇⡀⠄⠄⣠⠎
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣸⠁⠈⡟⠒⠲⣄⠄⠄⡰⠇⠖⢄⠄⠄⡹⡇⢀⠎
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⡇⠄⠄⡇⠄⠄⠹⠄⡞⠄⠄⢀⠤⣍⠭⡀⢱⢸
                ⠄⠄⠄⠄⠄⠄⢀⣀⣀⣠⠞⠄⠄⢠⡇⠄⠄⠄⠄⠁⠄⢴⠥⠤⠦⠦⡼⠄⢸
                ⣀⣤⣴⣶⣿⣿⡟⠁⠄⠋⠄⠄⠄⢸⠁⠄⠄⠄⠄⠄⠄⠄⠑⣠⢤⠐⠁⠄⢸
                ⣿⣿⣿⣿⣿⡟⠄⠄⠄⠄⠄⠄⠄⢸⡀⠄⠄⠄⠄⠄⠄⠄⠄⠬⠥⣄⠄⠄⠈⠲⡄
                ⣿⣿⣿⣿⣿⡇⠄⠄⠄⠄⠄⠄⠄⠄⠙⠦⣄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢳⠄⠄⢀⣿⡀
                ⣿⣿⣿⣿⣿⣧⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⠙⠒⠦⠤⢤⣄⣀⣠⠤⢿⣶⣶⣿⣿⣿⣶⣤⡀
                ⣿⣿⣿⣿⣿⣿⣷⣄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⡼⠁⠄⠄⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣄
                ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⣤⣤⣀⣀⣀⣀⣀⣀⣀⣤⣤⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ";
        }

    }
}