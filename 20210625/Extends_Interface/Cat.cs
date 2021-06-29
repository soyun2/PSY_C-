using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Cat : Animal, IFight
    {
        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("집사 너 내 주인이 되라");
        }

        public string eyeColor { get; set; }

        public override void Sleep()
        {
            //base.Sleep();
            System.Windows.Forms.MessageBox.Show("집사 나 잔다.");
        }

        public void DailyLootin()
        {
            Eat();
            Sleep();
        }

        public void Fight()
        {
            System.Windows.Forms.MessageBox.Show("캬오오오");
        }
    }
}
