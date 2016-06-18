using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    class GsmTest
    {
        public GsmTest(List<Gsm> gsmList)
        {
            this.GsmList = gsmList;
        }

        public List<Gsm> GsmList { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine(this.GsmList.Select(x => x.ToString()));
        }

        public void GetInfoForIPhone()
        {
            Console.WriteLine(Gsm.IPhone4Gs.ToString());
        }
    }
}
