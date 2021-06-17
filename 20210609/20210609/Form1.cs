using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_contents.Text = "";  //프로그램 시작할 때 label 안보이게, 디자인창에서는 보임
            //label_from_using.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox 치고 tab 키 2번
            MessageBox.Show("오랜만에 하는 c#");

            MessageBox.Show("안녕");
            MessageBox.Show("안녕");
            MessageBox.Show("안녕");
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textbox_contents.Text);
            MessageBox.Show(10+"안녕"+100);

            int 이한글 = 100;
            int 이재문 = 1000;
            string contents = string.Format("{0}+{1}={2}", 이한글, 이재문, 이한글 + 이재문);
            Console.WriteLine(contents);
            contents = $"{이한글}+{이재문}={이한글 + 이재문 + 9999}";
            Console.WriteLine(contents);
        }

        private void button_txtWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"./test.txt","안녕하세요~");
            File.WriteAllText(@"./test2.txt",textBox_memo.Text);  //파일 내용 덮어쓰기
        }

        private void button_readText_Click(object sender, EventArgs e)
        {
            label_contents.Text = File.ReadAllText("./test2.txt");
        }

        private void button_ctnwrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("./test2.txt",true))
            {
                writer.WriteLine(textBox_memo.Text);
            }
        }

        private void button_usingRead_Click(object sender, EventArgs e)
        {
            label_from_using.Text = "";
            using(StreamReader reader = new StreamReader("./text2.txt"))
            {
                string line;
                while((line=reader.ReadLine()) != null)
                {
                    label_from_using.Text += line + Environment.NewLine;
                    // Environment.NewLine = "\n"
                }
            }
        }
    }
}
