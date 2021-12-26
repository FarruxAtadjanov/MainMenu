using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MarketMenu
{
    internal class Magazin
    {
        public void Start()
        {
            Title = "Welcome!";
            RunMainMenu();
        }
        public void RunMainMenu()
        {
            string prompt = @"
 __      __       .__                                  __          
/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____  
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \ 
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/ 
       \/       \/          \/            \/     \/                
          _____                              .__                   
         /     \ _____     _________  _______|__| ____             
        /  \ /  \\__  \   / ___\__  \ \___   /  |/    \            
       /    Y    \/ __ \_/ /_/  > __ \_/    /|  |   |  \           
       \____|__  (____  /\___  (____  /_____ \__|___|  /           
               \/     \//_____/     \/      \/       \/            
                      
";

            string[] options = { "Add", "Delete", "Search", "Update", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            
            switch (selectedIndex)
            {
                case 0:
                    ADD();
                    break;
                case 1:
                    DeletE();
                    break;
                case 2:
                    SearCH();
                    break;
                case 3:
                    UpdatE();
                    break;
                case 4:
                    ExiT();
                    break;
            }
        }


        private void ExiT()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);

        }
        private void ADD()
        {

        }
        private void DeletE()
        {

        }
        private void SearCH()
        {

        }
        private void UpdatE()
        {

        }
    }
}
