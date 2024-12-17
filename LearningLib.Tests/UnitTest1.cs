
using LearningLib;
namespace LearningLib.Tests;

public class Tests
{

    [TestCase("0","0")]

    public void MyListAdd(string addition, string expectedStr)
    {
        MyList mylist = new MyList(4) ;
        mylist.Add(addition);
        Assert.That(mylist[0], Is.EqualTo(expectedStr));
    }

    
    

    [Test]
    public void MyListGetValue()
    {
        MyList mylist = new MyList(4);
        mylist.Add("1");
        mylist.Add("2");
        mylist.Add("3");
        mylist.Add("4");


        Assert.That(mylist.GetValue(2), Is.EqualTo("3"));
        Assert.That(mylist.count, Is.EqualTo(4));
    }

    [TestCase(0,"2")]
    public void MyListSetValue(int position, string expectedStr)
    {
        MyList mylist = new MyList(4);
       
        mylist.SetValue(expectedStr, position);
        Assert.That(mylist.GetValue(position), Is.EqualTo(expectedStr));
        Assert.That(mylist.count, Is.EqualTo(1));
    }

    [TestCase(2, "string")]
    public void MyListCollectionInitialiser(int position, string expectedStr)
    {
        MyList mylist = new MyList(3)
        {
           "s1", "s2", "s3"
        };
        mylist.SetValue(expectedStr, position);
        Assert.That(mylist[position], Is.EqualTo(expectedStr));
        Assert.That(mylist.count, Is.EqualTo(3));
    }

}
