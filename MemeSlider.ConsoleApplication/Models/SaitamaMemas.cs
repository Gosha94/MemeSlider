﻿using MemeSlider.ConsoleApplication.Contracts;

namespace MemeSlider.ConsoleApplication.Models
{
    internal sealed class SaitamaMemas : IMemas
    {

        public string ConcreteMemasName { get; private set; }

        public string ConcreteMemasView { get; private set; }
        

        public SaitamaMemas()
        {

            this.ConcreteMemasName = "Saitama";

            this.ConcreteMemasView =
            @"
                ⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣤⣤⣤⣤⣤⣤⣤⣤⣤⣀
                ⠄⠄⠄⠄⠄⠄⣠⡶⠛⠉⠄⠄⠄⠄⠄⠄⠄⠄⠄⠁⠙⢶⣀
                ⠄⠄⠄⠄⢀⡼⠋⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠹⣆
                ⠄⠄⠄⢠⡟⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢹⣆
                ⠄⠄⢀⡟⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢹⣆
                ⠄⠄⣾⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢿
                ⠄⢸⡿⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢸⣇
                ⠄⢸⣷⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢸⣿⡽⣆
                ⠄⠈⣿⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢈⣯⠻⢹⡄
                ⠄⠄⢸⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⣠⣤⣤⡄⠄⠄⠸⣿⠄⢸⡇
                ⠄⣼⠇⢿⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠴⠾⠛⣡⣤⣴⠶⠆⠄⠄⠟⢠⣿⠁
                ⠄⣿⠰⡟⣷⠄⠄⣤⣤⣤⣤⣤⣦⡀⠄⠄⠄⠄⣾⡋⣯⠄⣼⠇⠄⢠⣴⡿⠁
                ⠄⠹⣷⡀⢸⣧⠄⢶⣍⡉⠉⣤⣼⠇⠄⣦⠄⠄⠈⠛⠿⠟⠋⠄⠄⠈⠉
                ⠄⠄⠈⠻⣦⣹⣆⠄⠉⠻⠶⠟⠋⠄⠄⣿⠄⠄⠄⠄⠄⠄⠄⠄⠄⣸⣧⣀
                ⠄⠄⠄⠄⠘⠛⠻⣦⡀⠄⠄⠄⠄⠄⠄⢸⣇⡀⠄⠄⠄⠄⠄⠄⢰⣿⣿⣿⣿⣦
                ⠄⠄⠄⠄⠄⠄⠄⠙⣷⣄⠄⠄⠄⠄⠄⠄⠉⠁⠄⠄⠄⠄⠄⢀⣿⣿⣿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠄⢀⣴⠟⣡⣶⡀⠄⠄⠄⠄⠄⠾⠂⠄⠄⠄⢠⣾⣿⣿⣿⢱⣿⠏
                ⠄⠄⠄⠄⠄⢠⡙⣵⣿⣿⣿⠿⣷⣤⣀⡀⠄⠄⠄⠄⢀⣴⣿⣿⣿⣿⢣⣿⠏⠄
                ⠄⠄⠄⠄⢰⡟⠻⠈⠻⣿⣿⣄⡻⠉⠻⣿⣷⣶⣶⣾⣿⣿⣿⣿⣿⢡⣿⠏⡄⠄
                ⠄⠄⠄⢀⡟⠄⠄⠄⠰⢮⡛⠿⣿⣦⣄⡀⠈⠙⠻⢿⣿⣿⣿⣿⢧⣿⢏⡼⠁⣠
                ⠄⠄⠄⢸⡇⠄⠄⠄⠄⠄⠙⠲⠌⠛⢿⣏⠠⣤⣤⣶⣾⣿⣿⡟⢠⠇⠈⢀⣶⠟
                ⠄⠄⣰⠟⠛⠷⣶⣤⣤⣤⣄⡀⠄⢸⣶⣬⣛⠦⠉⠻⢿⣿⡿⠁⠋⠄⣾⣿⣇⠄
                ⢀⣼⠋⠄⠄⠄⠄⠈⠉⠙⠛⠻⢷⣾⣿⣿⣭⣧⡶⠂⠄⠄⠄⠄⠄⠄⠸⣿⣿⠄
                ⡾⠁⠄⠄⠄⠄⠄⠄⣀⠄⠄⠄⠄⠄⡌⣿⡃⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣿⣿⠄
                ⠄⠄⠄⢀⠄⠄⠄⣼⠇⠄⠄⠄⠄⠄⣷⢻⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠘⣿⡇
                ⣄⠄⠄⠸⡇⠄⣰⠏⠄⠄⠄⠄⠄⠄⢻⣸⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠛⠓
            ";

        }
    }
}