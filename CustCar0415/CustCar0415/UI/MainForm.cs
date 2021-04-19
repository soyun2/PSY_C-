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

namespace CustCar0415
{
    public partial class MainWin : MaterialForm
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void cxFlatRoundButton1_Click(object sender, EventArgs e)
        {

        }

        private void cxFlatRoundButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" + "2011년 4월 15일 by 박상신");
        }
        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit;
        }
    }
}
