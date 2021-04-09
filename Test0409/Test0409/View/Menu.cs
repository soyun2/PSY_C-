using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0408;

namespace Test0409.View
{
    class Menu
    {
        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_VIEW = 2;
        public const int MENU_MAIN_ADD = 3;
        public const int MENU_MAIN_DEL = 4;
        public const int MENU_MAIN_UPDATE = 5;
        public const int MENU_MAIN_EXIT = 6;

        public int mainMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("고객차량관리 앱 v1.0");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. 랜덤데이터 생성");
            Console.WriteLine("2. 데이터 보기");
            Console.WriteLine("3. 데이터 추가");
            Console.WriteLine("4. 데이터 삭제");
            Console.WriteLine("5. 데이터 수정");
            Console.WriteLine("6. 앱 종료");
            Console.WriteLine("--------------------");
            Console.Write("Main 메뉴 선택 : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int getRandSize()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("랜덤 데이터 갯수 설정");
            Console.WriteLine("----------------------");
            Console.WriteLine("갯수 입력: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public string[] addCarMenu()
        {
            string[] data = new string[4];

            Console.WriteLine("--------------------");
            Console.WriteLine("car데이터 추가");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Model : ");
            data[0] = Console.ReadLine();
            Console.WriteLine("2. Color : ");
            data[1] = Console.ReadLine();
            Console.WriteLine("3. Company : ");
            data[2] = Console.ReadLine();
            Console.WriteLine("4. Price : ");
            data[3] = Console.ReadLine();

            return data;
        }

        public Car addCarMenu2()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("car데이터 추가");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Model : ");
            string model = Console.ReadLine();
            Console.WriteLine("2. Color : ");
            string color = Console.ReadLine();
            Console.WriteLine("3. Company : ");
            string company = Console.ReadLine();
            Console.WriteLine("4. Price : ");
            string price = Console.ReadLine();

            return new Car(model,color,company,price);
        }
    }
}
