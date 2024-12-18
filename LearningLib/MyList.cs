using System;
using System.Collections;
using System.Collections.Generic;


public class MyList<T> : IEnumerable<T>
{
    public T[] list;
    public int count = 0;
    public MyList (int size)
    {
        list = new T[size];

    }
    public void Add(T element)
    {
        if (count == list.Length)
        {
            list = ExpandSize(list);
        }

        list[count] = element;
        count++;
    }

    public T GetValue(int position)
    {
        return list[position];
    }

    public void SetValue(T setString, int position)
    {
        list[position] = setString;
    }


    public T[] ExpandSize(T[] smallList)
    {
        return new T[smallList.Length * 2];
    }

    public T this[int index]
    {
        get { return list[index]; }
    }
   

     IEnumerator<T> IEnumerable<T>.GetEnumerator()
     {   
         for (int i = 0; i < count; i++)
         {
             yield return this[i];
         }
     }
    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return this[i];
        }
    }
    
    
     
        
}   
