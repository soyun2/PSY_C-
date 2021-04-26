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
    partial class UcAddCust : UserControl
    {
        UnionController uHandler;
        char gender;
        public delegate void AddCustConfirmEventHandler(object sender, EventArgs e);
        public event AddCustConfirmEventHandler addCustConfirmEvent;
        public UcAddCust()
        {
            InitializeComponent();
        }
        public UcAddCust(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }


        private void ucAddCustOk_Click(object sender, EventArgs e)
        {
            string name = ucAddCustName.Text;
            string age = ucAddCustAge.Text;
            string tel = ucAddCustTel.Text;
            string addr = ucAddCustAddr.Text;
            uHandler.CustHandle.addItem(new Customer(name, Convert.ToInt32(age), tel, addr, gender));
            MessageBox.Show("고객 정보가 등록되었습니다.");
            ucAddCustOk.Enabled = false;
            if (addCustConfirmEvent != null)
            {
                addCustConfirmEvent(this, new EventArgs());
            }
        }

        private void ucAddCustInit_Click(object sender, EventArgs e)
        {

        }

        private void ucAddCustMan_ValueChanged(object sender, bool value)
        {
            Sunny.UI.UIRadioButton rd = sender as Sunny.UI.UIRadioButton;
            if(rd.Checked == false)
            {
                return;
            }
            if(rd.Name.Equals("ucAddCustMan"))
            {
                gender = '남';
            }
            else
            {
                gender = '여';
            }
        }
    }
}
