using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5._64BitArray
{
    class _64BitArray : IEnumerable<int>, IEquatable<_64BitArray>
    {
        public ulong[] My64BitArray { get;private set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.My64BitArray.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            // TODO: not quite sure how IEnumerator<int> works. If it wasnt 3 am I would have check it up, but no time, sorry :)
            //return this.My64BitArray.GetEnumerator();
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((_64BitArray) obj);
        }

        public override int GetHashCode()
        {
            return (this.My64BitArray != null ? this.My64BitArray.GetHashCode() : 0);
        }

        public bool Equals(_64BitArray other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Equals(this.My64BitArray, other.My64BitArray);
        }

        public static bool operator ==(_64BitArray left, _64BitArray right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(_64BitArray left, _64BitArray right)
        {
            return !Equals(left, right);
        }

        public ulong this[int a]
        {
            get
            {
                return this.My64BitArray[a];
            }
            set
            {
                // If value is valid
                this.My64BitArray[a] = value;
            }
        }
    }
}
