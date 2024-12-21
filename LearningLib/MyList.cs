using System;
using System.Collections;
using System.Collections.Generic;


public class MyList<T> : IEnumerable<T>, IEnumerator<T>
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
    //Здесь будет реализация методов и свойств интерфейса IEnumerator<T>

    public int position = -1;
    public void Reset()
    {
        position = -1;
    }
    public T Current
    {
        get
        {
            if (position < count)
            {
                return list[position];
            }
            else
            {
                throw new ArgumentException();
            }
        } 

    }
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    public bool MoveNext()
    {
        if (position < count - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
    
     
        
}   
