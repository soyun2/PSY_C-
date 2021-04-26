using CustCar0415.Controll;
using CustCar0415.Model;
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
    partial class UcAddSell : UserControl
    {
        UnionController uHandler;
        public delegate void AddSellConfirmEventHandler(object sender, EventArgs e);
        public event AddSellConfirmEventHandler addSellConfirmEvent;
        public UcAddSell()
        {
            InitializeComponent();
        }
        public UcAddSell(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void ucAddSellOk_Click(object sender, EventArgs e)
        {
            string name = ucAddSellName.Text;
            string tel = ucAddSellTel.Text;
            string jikwi = ucAddSellJikwi.Text;
            string store = ucAddSellStore.Text;
            uHandler.SellHandle.addItem(new Seller(name, tel, jikwi, store));
            MessageBox.Show("판매자 정보가 등록되었습니다.");
            ucAddSellOk.Enabled = false;
            if (addSellConfirmEvent != null)
            {
                addSellConfirmEvent(this, new EventArgs());
            }
        }
    }
}
