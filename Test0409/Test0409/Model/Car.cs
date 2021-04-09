using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0408
{
    class Car
    {
        public string model;
        private string color;
        private string company;
        private string price;

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Price { get => price; set => price = value; }

        public Car()
        {
            model = "아반떼";
            color = "흰색";
            company = "현대";
            price = "2천만원";
        }

        public Car(string model, string color, string company, string price)
        {
            this.model = model;
            this.color = color;
            this.company = company;
            this.price = price;
        }
        public void printInfoCar()
        {
            Console.WriteLine("모델 = " + model);
            Console.WriteLine("색깔 = " + color);
            Console.WriteLine("회사 = " + company);
            Console.WriteLine("가격 = " + price);
            Console.WriteLine("----------------------");
        }
        public override string ToString()
        {
            string str = "모델 : " + model + "\n";
            str += "색깔 : " + color + "\n";
            str += "제조사 : " + company + "\n";
            str += "가격 : " + price + "\n";
            str += "------------------------";
            return str;
        }
    }
}
