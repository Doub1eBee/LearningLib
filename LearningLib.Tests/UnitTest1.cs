
using LearningLib;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Transactions;
namespace LearningLib.Tests;


public class TestsMyList
{

    [TestCase("0","0")]

    public void MyListAdd(string addition, string expectedStr)
    {
        MyList<string> mylist = new MyList<string>(4) ;
        mylist.Add(addition);
        Assert.That(mylist[0], Is.EqualTo(expectedStr));
    }

    
    

    [Test]
    public void MyListGetValue()
    {
        MyList<int> mylist = new MyList<int>(4);
        mylist.Add(1);
        mylist.Add(2);
        mylist.Add(3);
        mylist.Add(4);


        Assert.That(mylist.GetValue(2), Is.EqualTo(3));
        Assert.That(mylist.count, Is.EqualTo(4));
    }

    [TestCase(0,"2")]
    public void MyListSetValue(int position, double expectedDouble)
    {
        MyList<double> mylist = new MyList<double>(4) {1.0, 2.0, 3.1, 4.5 };
        
        mylist.SetValue(expectedDouble, position);
        Assert.That(mylist.GetValue(position), Is.EqualTo(expectedDouble));
        Assert.That(mylist.count, Is.EqualTo(4));
    }

    [TestCase(2, "string")]
    public void MyListCollectionInitialiser(int position, string expectedStr)
    {
        MyList<string> mylist = new MyList<string>(3)
        {
           "s1", "s2", "s3"
        };
        mylist.SetValue(expectedStr, position);
        Assert.That(mylist[position], Is.EqualTo(expectedStr));
        Assert.That(mylist.count, Is.EqualTo(3));
    }

    [TestCase(5)]
    public void MyListForeach(int size)
    {
        MyList<string> stringList = new MyList<string>(size) 
        { 
            "str1", "str2", "str3", "str4", "str5" 
        };
        bool isPassed = false;
        foreach (string item in stringList)
        {
            Console.Write(item + " ");
            isPassed = true;
        }
       Assert.IsTrue(isPassed);  

    }
    [TestCase(5)]
    public void MyListNoForeach(int size)
    {
        MyList<string> stringList = new MyList<string>(size)
        {
            "str1", "str2", "str3", "str4", "str5"
        };
        bool isPassed = false;
        while (stringList.MoveNext())
        {
            string item = stringList.Current;
        }
        if (stringList.position == stringList.count - 1)
        {
            string item = stringList.Current;
            isPassed = true;
            stringList.Reset();
            stringList.Dispose();
        }
        
        Assert.IsTrue(isPassed);
    }

}
