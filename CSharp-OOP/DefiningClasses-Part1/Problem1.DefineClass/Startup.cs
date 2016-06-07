using System.Collections.Generic;

namespace Problem1.DefineClass
{
    class Startup
    {
        // You can play around with the code to test its functionality.

        static void Main()
        {
            Gsm gsm = new Gsm("iphone");
            Gsm gsm1 = new Gsm("iphon3");
            Gsm gsm2 = new Gsm("iphone2");

            GsmTest gsmtest = new GsmTest(new List<Gsm>() { gsm, gsm1, gsm2 });

            gsmtest.GetInfoForIPhone();
        }
    }
}
