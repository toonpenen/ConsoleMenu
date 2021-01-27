using ConsoleMenuLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConsoleMenuOperation> menuOperations = new List<ConsoleMenuOperation>()
            {
                new MainMenu.MainMenuOperation_RunSubProgram1(),
                new MainMenu.MainMenuOperation_RunSubProgram2(),
                new MainMenu.MainMenuOperation_ExitApp()
            };
            
            ConsoleMenu mainMenu = new ConsoleMenu("Main Menu", menuOperations, "Please choose Sub Program: ");
            
            mainMenu.Run();
        }
    }
}
