using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteXML
{
    class Drug
    {
        public string DurName { get; set; }
        public string DurID { get; set; }
        public string DurComp { get; set; }

        public Drug(string durName, string durId, string durComp)
        {
            this.DurName = durName;
            this.DurID = durId;
            this.DurComp = durComp;
        }
    }
}
