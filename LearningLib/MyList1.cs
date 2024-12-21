using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace LearningLib
{
    public class MyList1<T> : IEnumerator<T>
    {
        T[] list;
        int count = 0;
        public MyList1(int size)
        {
            list = new T[size];  
        }
        public void Add(T value)
        {
            if (list.Length == count)
            {
                list = ExpandSize(list);
            }
            list[count] = value;
            count++;
        }
        public void SetValue(T value, int position)
        {
            list[position] = value;
        }
        public T GetValue(int position)
        {
            return list[position];
        }
        public T[] ExpandSize(T[] smallList)
        {
            return new T[smallList.Length * 2]; 
        }

        public void MyEnumerator()
        {
            while (MoveNext())
            {
                T value = Current;
            }
            if (position == count - 1)
            {
                T value = Current;
                Reset();
                Dispose();
            }
        }

        public T this[int position]
        {
            get { return list[position]; }
            set { list[position] = value; }
        }
        //Здесь будет реализация методов интерфейса IEnumerator<T>
       
        int position = -1;
        public bool MoveNext()
        {
            if (position <= count)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            position = -1;
        }

        
        public T Current
        {
            get
            {
                return list[position];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        
        
        
    }
   
}
