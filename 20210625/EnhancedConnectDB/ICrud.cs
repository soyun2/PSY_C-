using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedConnectDB
{
    interface ICrud
    {
        void Query_Select();
        void Query_Insert(string cust_id, string birth_dt);
        void Query_Delete();
        void Query_Update(string cust_id, string birth_dt);

    }
}
