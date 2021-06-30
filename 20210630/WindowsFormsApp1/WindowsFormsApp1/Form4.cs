using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form, Observer
    {
        Form2 frm2;
        Subject sub;

        public Form4(Subject sub, Form2 frm2)
        {
            this.sub = sub;
            this.frm2 = frm2;
            InitializeComponent();
        }

        public void update(string value)
        {
            Console.WriteLine("...");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            sub.register(frm2);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            sub.remove(frm2);
        }
    }
}
