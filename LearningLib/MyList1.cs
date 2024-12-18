using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace LearningLib
{
    public class MyList1<T> : IEnumerable
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
        public T this[int position]
        {
            get { return list[position]; }
            set { list[position] = value; }
        }
       
         IEnumerator IEnumerable.GetEnumerator()
        {
            MyList1<T> outList = new MyList1<T>(list.Length -1);
            int i = 0;
            while (i < count)
            {
                outList[i] = list[i];
                i++;
            }
            return (IEnumerator)outList;
        }
        
    }
}
