using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    internal class GsmCallHistoryTest
    {
        private const decimal PRICE_PER_MINUTE = 0.37m;

        public Gsm Gsm { get; set; }

        public void GetTotalCallPrice()
        {
            Console.WriteLine(this.Gsm.CalculatePrice(PRICE_PER_MINUTE));
        }

        public void RemoveLongestCall()
        {
            this.Gsm.CallHistory.Remove(this.Gsm.CallHistory.OrderBy(x => x.CallDurationInSeconds).FirstOrDefault());
        }
    }
}
