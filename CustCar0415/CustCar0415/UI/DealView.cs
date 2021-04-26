using ClassTeCustCar0415st2_1.Controll;
using CustCar0415.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    public partial class DealView : MaterialForm
    {
        UnionController uHandler = new UnionController(new RandData());
        public DealView()
        {
            InitializeComponent();
        }

        private void initDealSmListView()
        {
            //string[] data = { "1", "그랜저", "4천만원", "홍길동", "전우치", "2021년4월16일", "3천8백만원" };
            //dealSmListView.Items.Add(new ListViewItem(data));
            for (int i = 0; i < 50; i++)
            {
                dealSmListView.Items.Add(new ListViewItem(
                new string[]
                {
                    (i+1).ToString(),"그랜저","4천만원","홍길동","전우치","2021년4월16일","3천8백만원"
                }
                ));

            }
            setRowColor(Color.White, Color.LightSkyBlue);
            int index = dealSmListView.Items.Count - 1;
            dealSmListView.Items[index].Selected = true;
            dealSmListView.Items[index].Focused = true;
            dealSmListView.EnsureVisible(index);
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealSmListView();
        }

        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setRowColor(Color color1, Color color2)
        {
            foreach (ListViewItem item in dealSmListView.Items)
            {
                if((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }
    }
}
