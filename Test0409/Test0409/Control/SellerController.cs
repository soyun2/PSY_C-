using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0409.Model;
using Test0409.Util;

namespace Test0409.Control
{
    class SellerController
    {
        List<Seller> s_list = new List<Seller>();
        RandData rand;
        public SellerController(RandData rand)
        {
            this.rand = rand;
        }
        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                s_list.Add(new Seller(rand.getName(), rand.getEmpid(), rand.getTel(), rand.getDep()));
            }
        }
        public void sellerView()
        {
            for (int i = 0; i < s_list.Count; i++)
            {
                Console.WriteLine(s_list[i].ToString());
            }
        }
        public void sellerView2()
        {
            for (int i = 0; i < s_list.Count; i++)
            {
                s_list[i].SellerInfor();
            }
        }
        public void removeAll()
        {
            s_list.Clear();
        }
    }
}
