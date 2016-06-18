using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.DefineClass
{
    internal class Gsm
    {
        private static Gsm iPhone4gs = new Gsm("Apple");

        public Gsm(string manufacturer, int price = 0, string owner = null, Battery battery = null, Display display = null, Gsm iphone = null)
        {
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public List<Call> CallHistory { get; set; }

        public string Manufacturer { get; set; }

        public int Price { get; set; }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static Gsm IPhone4Gs
        {
            get
            {
                return iPhone4gs;
            }
            set
            {
                // Add whatever validation you would need here.
                iPhone4gs = value;
            }
        }

        public override string ToString()
        {
            return
                string.Format(
                              "This phone is made by {0},sold at the price of {1}, the owner is {2}... you get it how this works",
                              this.Manufacturer,
                              this.Price,
                              this.Owner);
        }

        public void AddCall(Call callToAdd)
        {
            // if valid add
            this.CallHistory.Add(callToAdd);
        }

        public void DeleteCall(Call callToDelete)
        {
            // if there is such a call
            if (!this.CallHistory.Contains(callToDelete))
            {
                return;
            }

            this.CallHistory.Remove(callToDelete);
        }

        public void ClearHistory()
        {
            // if valid user request the operation
            this.CallHistory.Clear();
        }

        public decimal CalculatePrice(decimal pricePerMinute)
        {
            return this.CallHistory.Sum(x => x.CallDurationInSeconds) * pricePerMinute;
        }
    }
}
