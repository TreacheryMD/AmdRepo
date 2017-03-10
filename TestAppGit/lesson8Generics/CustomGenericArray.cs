using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8Generics
{
    class CustomGenericArray<T>
    {
        private T[] _items;
        private const int maxLenght = 20;
        public CustomGenericArray()
        {
            _items = new T[maxLenght];
        }

        public CustomGenericArray(int capacity)
        {
            if (capacity < 0 || capacity > 20) throw new Exception("Capacity can't be less then 0 or higher then 20");

            if (capacity == 0)
                _items = new T[maxLenght];
            else
                _items = new T[capacity];
        }
        public T this[int index]
        {
            get
            {
                return _items[index];
            }

            set
            {
                _items[index] = value;
            }
        }

        public void SwapByIndex(int index,int index2)
        {
            var temp = _items[index];
            _items[index] = _items[index2];
            _items[index2] = temp;

        }

        public void SwapByValue(T value, T value2)
        {
            int[] iValue = EM.FindAllIndexof(_items, value);
            int[] iValue2 = EM.FindAllIndexof(_items, value2);

            foreach (var item in iValue)
            {
                _items[item] = value2;
            }

            foreach (var item in iValue2)
            {
                _items[item] = value;
            }
        }

    }
}
