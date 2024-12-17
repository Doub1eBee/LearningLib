using System;
using System.Collections;

public class MyList : IEnumerable
{
    public string[] list;
    public int count = 0;
    public MyList(int size)
    {
        list = new string[size];

    }
    public void Add(string element)
    {
        if (count == list.Length)
        {
            list = ExpandSize(list);
        }

        list[count] = element;
        count++;
    }

    public string GetValue(int position)
    {
        return list[position];
    }

    public void SetValue(string setString, int position)
    {
        list[position] = setString;
    }


    public string[] ExpandSize(string[] smallList)
    {
        return new string[smallList.Length * 2];
    }

    public string this[int index]
    {
        get { return list[index]; }
    }
   

    IEnumerator IEnumerable.GetEnumerator()
    {   
       for (int i = 0; i < count; i++)
       {
            yield return this[i];
       }
    }
    
     
        
}   
