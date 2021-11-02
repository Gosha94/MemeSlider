using MemeSlider.ConsoleApplication.Contracts;

namespace MemeSlider.ConsoleApplication.Models
{
    internal sealed class VoyakaMemas : IMemas
    {
        public string ConcreteMemasName { get; private set; }

        public string ConcreteMemasView { get; private set; }

        public VoyakaMemas()
        {

            this.ConcreteMemasName = "Voyaka";

            this.ConcreteMemasView =
            @"
                ⠟⠛⠉⠉⠉⠉⠉⠉⠙⠛⠻⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠉⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠙⠻⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢻⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⢀⣀⣀⣀⣀⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⢻⣿⣿⣿
                ⠄⠄⠄⠉⠉⠉⠄⣀⣀⣀⡈⠉⠛⠛⠛⠉⠉⠲⠄⠄⠄⣿⣿⣿
                ⠠⠤⠤⠔⠒⠋⠉⠄⠄⠄⠈⠉⠒⠒⠒⠒⠒⠂⠄⠄⠄⢻⣿⣿
                ⠄⠄⢀⠤⠐⠒⠒⠒⠒⠂⠄⠄⠄⠄⠄⠐⠒⠒⠒⢄⠄⠄⢿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⠆⠄⠄⠄⠄⢰⠄⠄⠄⠄⠄⠄⢸⣿
                ⠄⠄⠄⢠⡖⢲⣶⣶⣤⡀⠄⠄⠄⠄⠄⠈⢀⣤⣤⣤⡀⠄⢸⣿
                ⠄⠄⠄⠈⠙⠚⠛⠛⠓⠃⠄⠄⠄⠄⠄⠄⠧⠤⢿⣿⡇⠄⢸⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢰⡆⠄⠄⠄⠄⠄⠄⠄⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠳⡀⠄⠄⠄⠄⠄⠄⢸
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⡤⠤⠄⠄⠄⠄⠄⢘⡆⠄⠄⠄⠄⢠⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠻⣤⠄⠴⠆⠠⣄⡞⠄⠄⠄⠄⢀⣾⣿
                ⣆⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣾⣿⣿
                ⠈⠳⣄⠄⠄⠄⠄⠄⠖⠒⠶⠤⠤⠤⠤⠤⢤⠄⠄⢀⣿⣿⣿⣿
                ⠄⠄⠈⠑⢦⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣼⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠙⢦⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⣠⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠈⠓⠲⠤⠤⠤⣤⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠣⡀⠄⠄⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠉⠉⠉⠉⠉⠉⠛⠛
                ⠄⠄⠈⠉⠑⢆⣀⡔⠈⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄
            ";
        }

    }
}
