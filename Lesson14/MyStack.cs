using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public class MyStack<T>
    {
        private T[] values;
        private int index;
        public MyStack() 
        {
            values = new T[10];
            index = -1;
        }
        public void Push (T value)
        {
            if (values.Length - 1 == index)
            {
                Array.Resize (ref values, values.Length*2);
            }
            index++;
            values[index] = value;
        }
        public T Pop()
        {
            if (index == -1)
            {
                throw new IndexOutOfRangeException ("It's ampty");
            }
            var _elem = values[index];
            index--;
            return _elem;
        }
        public void Clear()
        {
            Array.Clear (values, 0, values.Length);
            index = -1;
        }
        public int Count => index + 1;
        public T Peek()
        {
            if (index == -1)
            {
                throw new IndexOutOfRangeException("It's ampty");
            }
            return values[index];
        }
        public void CopyTo(ref T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException ("Array can't be NULL");
            }
            Array.Resize(ref array, values.Length);
            Array.Copy(values, array, values.Length);
        }
    }
}
