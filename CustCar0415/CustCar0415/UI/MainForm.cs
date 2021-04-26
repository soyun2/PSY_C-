using ClassTeCustCar0415st2_1.Controll;
using CustCar0415.UI;
using CustCar0415.Util;
using CustCar0415.View;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415
{
    public partial class MainWin : MaterialForm
    {
        MyMenu menu = new MyMenu();
        UnionController uHandler = new UnionController(new RandData());

        public MainWin()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0 \n"+"2021년 4월 15일 by 이한글");
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //추가
        private void RandDataAdd_Click(object sender, EventArgs e)
        {
            string size = myIputBox("랜덤 데이터 추가","랜덤하게 생성할 데이터 갯수를 입력하세요","0");
            uHandler.insRandData(Convert.ToInt32(size));
        }

        //삭제
        private void RandDataDel_Click(object sender, EventArgs e)
        {
            uHandler.removeAll();
        }

        //보기
        private void DataView_Click(object sender, EventArgs e)
        {
            uHandler.dealView();
            new DealView().ShowDialog(); //show는 창전환이 가능하고 showdialog는 창을끄기전까지 전환불가
        }

        //폰트
        public void initFont()
        {
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("폰트3.ttf");
            PrivateFontCollection tFont = new PrivateFontCollection();
            tFont.AddFontFile("가비아.ttf");

            Font font = new Font(pFont.Families[0], 16f);
            Font Tfont = new Font(tFont.Families[0], 16f);
            Sunny.UI.UIButton[] btnArr = {RandDataAdd,RandDataDel,DataView,DataAdd,DataUpdate, DataDel};
            mainTitle.Font = Tfont;
            
            foreach (var n in btnArr)
            {
                n.Font = font;
            }
        }

        // 입력창
        public string myIputBox(string title, string body , string prompt)
        {
            string input =  Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }

        //데이터 추가
        private void DataAdd_Click(object sender, EventArgs e)
        {

        }

        //데이터 수정
        private void DataUpdate_Click(object sender, EventArgs e)
        {

        }

        //데이터 삭제
        private void DataDel_Click(object sender, EventArgs e)
        {

        }

        
        private void MainWin_Load(object sender, EventArgs e) //시작시 바로 시작됨
        {
            initFont();
        }


        private void mainTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
