using System;
using LmsApp.Menus;

namespace LmsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.display();
            Thread.Sleep(1);
        }
    }
}
