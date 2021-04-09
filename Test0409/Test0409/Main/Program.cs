using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0408;
using Test0409.Control;
using Test0409.Model;
using Test0409.Util;
using Test0409.View;


namespace Test0409
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData();
            Menu menu = new Menu();
            CarController carct = new CarController(rand);
            
            while (true)
            {
                switch (menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        carct.insRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        carct.carView();
                        break;
                    case Menu.MENU_MAIN_ADD:
                        break;                       
                    case Menu.MENU_MAIN_DEL:
                        carct.removeAll();
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
                      
        }
    }
}
