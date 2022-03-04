using System;
using SchoolVotingSystem.Menu;

namespace SchoolVotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext Context = new();

            MainMenu menu = new MainMenu(Context);

            menu.Election();
        }
    }
}
