using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RangeExceptions
{
    // TODO : The task is unclear for me so I have not implemented a solution.
    class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string message) : base(message)
        {
        }
    }
}
