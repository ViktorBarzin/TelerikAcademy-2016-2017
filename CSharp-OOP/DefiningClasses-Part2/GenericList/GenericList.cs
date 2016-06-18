using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // If you want full functionality, use List<T> you lazy !#$%.
    public class GenericList<T>
    {
        private const int DEFAULT_SIZE = 16;
        private T[] array;
        private int size;
        private int currentIndex;

        public GenericList(int size)
        {
            this.size = size;
            this.InitializeArr(size);
            this.currentIndex = 0;
        }

        public T this[int index]
        {
            // Getter and setter can be improved by reverting the thernary operator to and if to throw exceptions
            // if invalid index is passed.
            get
            {
                return index >= 0 ? this.array[index] : this.array[0];
            }
            set
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.array[index] = value;
            }
        }

        public T Min()
        {
            return this.array.Min();
        }

        public T Max()
        {
            return this.array.Max();
        }

        public void RemoveAt(int index)
        {
            // TODO : move all elements right after deleting
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            this.array[index] = default(T);
        }

        public void Remove(T item)
        {
            // TODO : move all elements right after deleting
            if (!this.array.Contains(item))
            {
                throw new ArgumentException(string.Format("Array does not contain {0}", item));
            }

            for (int i = 0; i < this.array.Length; i++)
            {
                // Override == and != operator for better results
                if (!this.array[i].Equals(item))
                {
                    continue;
                }

                this.array[i] = default(T);
                break;

            }
        }

        public void Add(T item)
        {
            if (this.currentIndex >= this.size)
            {
                this.Expand();
                this.array[this.currentIndex] = item;
            }
            else
            {
                this.array[this.currentIndex] = item;
            }
            this.currentIndex++;
        }

        private void Expand()
        {
            T[] arr = new T[this.array.Length * 2];
            for (int i = 0; i < this.array.Length; i++)
            {
                arr[i] = this.array[i];
            }

            this.array = arr;
            this.size <<= 1;
        }

        private void InitializeArr(int initialSize)
        {
            this.array = initialSize >= 0 ? new T[initialSize] : new T[DEFAULT_SIZE];
        }
    }
}
