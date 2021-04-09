using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0409.Model;
using Test0409.Util;

namespace Test0409.Control
{
    class CustomerController
    {
        List<Customer> c_list = new List<Customer>();
        RandData rand;
        public CustomerController(RandData rand)
        {
            this.rand = rand;
        }
        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                c_list.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddress(),rand.getGender()));
            }
        }
        public void customerView()
        {
            for (int i = 0; i < c_list.Count; i++)
            {
                Console.WriteLine(c_list[i].ToString());
            }
        }
        public void carView2()
        {
            for (int i = 0; i < c_list.Count; i++)
            {
                c_list[i].CustomerInfor();
            }
        }
        public void removeAll()
        {
            c_list.Clear();
        }
    }
}
