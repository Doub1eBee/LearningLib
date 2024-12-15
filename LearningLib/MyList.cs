using System;

public class MyList
{
	public string[] list;
	public int count = 0;
	public MyList(int size)
	{
		list = new string[size];
		
	}
	public void Insert(string element, int position)
	{
		if (count == list.Length) 
			ExpandSize(list); 

		bool isInsert = false;
		string[] tempList = new string[list.Length + 1];
		for (int i = 0; i < tempList.Length; i++)
		{
			
			if (i == position - 1)
			{
				tempList[i] = element;
				isInsert = true;
				continue;
			}
			if (isInsert)
			{
				tempList[i] = list[i - 1];	
			}
			else
			{
				tempList[i] = list[i];
			}
			if (String.IsNullOrEmpty(list[i]))
				break;
		}
		list = tempList;
		count++;
		
	}
	public void Delete(int position, int number)
	{
		bool isDelete = false;
		string[] tempList = new string[list.Length - number];
		for (int i = 0; i < tempList.Length; i++)
		{
            if (i == position - 1)
			{
				isDelete = true;
			}
			if (isDelete)
			{
				tempList[i] = list[i + number];
				
			}
			else
			{
				tempList[i] = list[i];
			}
			
            if (String.IsNullOrEmpty(list[i]))
                break;
		}
		count-=number;

	}
	public string GetValue(int position)
	{
		if (list.Length >= position)
		{
			if (list.Length != 0 && list != null)
				return list[position - 1];
			else
				return null;
		}
		else 
			return null;
		
	}
	public void SetValue(string setString, int position)
	{
        if (list.Length >= position && list.Length != 0 && list != null)
        {
            list[position - 1] = setString;
        }
       
	}
	public void Iterate()
	{
        if (list.Length != 0 && list != null)
            foreach (string str in  list)
			{
				Console.Write(str + " ");
			}
	}
	public void InsertToEnd(string insert)
	{

		if (list.Length != 0 && list != null)
		{
			if (string.IsNullOrEmpty(list[list.Length - 1]))
			{
				list[list.Length - 1] = insert;
				if (count == list.Length)
					ExpandSize(list);
				count++;
			}
		}
		else
		{
			list = new string[1] { insert };
			count++;
		}
		
	}
	public void DeleteFromEnd()
	{
		if (!string.IsNullOrEmpty(list[list.Length - 1]));
		{
			list[list.Length - 1] = null;
			count--;
		}
	}
	public string[] ExpandSize(string[] smallList)
	{
		return new string[smallList.Length * 2];
	}
	
	
}
