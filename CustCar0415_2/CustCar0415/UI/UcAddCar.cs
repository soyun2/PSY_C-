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
    partial class UcAddCar : UserControl
    {
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;
        public delegate void AddCarConfirmEventHandler(object sender, EventArgs e);
        public event AddCarConfirmEventHandler addCarConfirmEvent;

        public UcAddCar()
        {
            InitializeComponent();
        }

        public UcAddCar(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        public UcAddCar(UnionController uHandler, AddData ad)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
            Console.WriteLine("index : " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();            
            return item;
        }
        private void uccomboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            infoModel.Text = model;
            infoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "그랜저":
                    ucpictureBox1.Image = Properties.Resources.gran;
                    ucpictureBox2.Image = Properties.Resources.gran_side;
                    ucpictureBox3.Image = Properties.Resources.gran_back;
                    ucpictureBox4.Image = Properties.Resources.gran_in;
                    break;
                case "우루스":
                    ucpictureBox1.Image = Properties.Resources.urus;
                    ucpictureBox2.Image = Properties.Resources.urus_side;
                    ucpictureBox3.Image = Properties.Resources.urus_back;
                    ucpictureBox4.Image = Properties.Resources.urus_in;
                    break;
                case "제네시스":
                    break;
                case "K8":
                    break;
                case "K7":
                    break;
            }
        }

        private void uccomboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            infoCompany.Text = company;
            infoCompany.ForeColor = Color.Red;
        }

        private void uccomboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            infoColor.Text = color;
            infoColor.ForeColor = Color.Red;
        }

        private void uccomboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            infoPrice.Text = price;
            infoPrice.ForeColor = Color.Red;
        }

        private void ucaddCarOk_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                uccomboModel.Select();
                return;
            }
            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                uccomboModel.Select();
                return;
            }
            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                uccomboModel.Select();
                return;
            }
            if (company == null)
            {
                MessageBox.Show("제조사를 선택하세요.");
                uccomboModel.Select();
                return;
            }
            uHandler.CarHandle.addItem(new Car(model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            ucaddCarOk.Enabled = false;
            if (addCarConfirmEvent != null)
            {
                addCarConfirmEvent(this, new EventArgs());
            }
        }

        private void ucaddCarReset_Click(object sender, EventArgs e)
        {

        }
    }
}
