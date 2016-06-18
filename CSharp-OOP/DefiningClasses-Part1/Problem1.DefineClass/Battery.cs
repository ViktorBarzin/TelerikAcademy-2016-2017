using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    internal class Battery
    {
        private BatteryType batteryType;

        public Battery(string model, int hoursIdle, string hourseTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HourseTalk = hourseTalk;
            this.batteryType = BatteryType.LiIon;
        }

        public string Model { get; set; }

        public int HoursIdle { get; set; }

        public string HourseTalk { get; set; }
    }
}
