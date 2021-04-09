using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0408;
using Test0409.Util;

namespace Test0409.Control
{
    class CarController
    {        
        List<Car> list = new List<Car>();
        RandData rand;
        public CarController(RandData rand)
        {
            this.rand = rand;
        }
        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Car(rand.getModel(),rand.getColor(),rand.getCompany(),rand.getPrice()));
            }
        }
        public void carView()
        {
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
        public void carView2()
        {
            for(int i =0;i<list.Count;i++)
            {
                list[i].printInfoCar();
            }
        }

        public void removeAll()
        {
            
            list.Clear();
        }

        public void addCarItem()
        {

        }
    }
}
