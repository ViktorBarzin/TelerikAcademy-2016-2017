using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    internal class Call
    {
        public Call(DateTime dateTime, string dialledPhoneNumber, int callDurationInSeconds)
        {
            this.DateTime = dateTime;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.CallDurationInSeconds = callDurationInSeconds;
        }

        // Task does not require adding validation, otherwise add validation
        public DateTime DateTime { get; set; }

        public string DialledPhoneNumber { get; set; }

        public int CallDurationInSeconds { get; set; }
    }
}
