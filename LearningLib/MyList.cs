using System;

public class MyList
{
	public string[] list;
	public int count = 0;
	public MyList(int size)
	{
		list = new string[size];
		
	}
	public void Add(string element, int position)
	{
		if (count == list.Length)
		{
			list = ExpandSize(list);
			list[count] = element;
		}
        else
        {
			if (list[position] == null)
			{
				list[position] = element;
			}
			else
			{
				string[] tempList = new string[count + 1];
				for (int i = 0; i < count; i++)
				{
					if (i < position)
					{
						tempList[i] = list[i];
					}
					else if (i == position)
					{
						tempList[i] = element;
					}
					else
					{
						tempList[i] = list[i+1];
					}
				}
			}
        }
		count++;
    }
	public void Delete(int position, int number)
	{
		while (number > 0)
		{
			list[position] = null;
			number--;
			position++;
			count--;
		}
	}
	public string GetValue(int position)
	{ 
		if (list != null)
		{
			return list[position];
		}
		else
		{
			return null;
		}
	
	}
		
		
	
	public void SetValue(string setString, int position)
	{
		list[position] = setString;
	}
	public void Iterate()
	{
        if (list != null)
		{
            foreach (string str in  list)
			{
				Console.Write(str + " ");
			}
		}
	}
	
	
	public string[] ExpandSize(string[] smallList)
	{
		return new string[smallList.Length * 2];
	}
	
	
}
