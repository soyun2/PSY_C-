using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface Subject
    {
        //메소드 이름은 통상적으로 register or subscribe
        void register(Observer o);
        //remove or dissubscribe
        void remove(Observer o);
        void notifyObservers();
    }
}
