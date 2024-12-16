
using LearningLib;
namespace LearningLib.Tests;

public class Tests
{

    [Test]

    public void MyListAdd()
    {
        MyList l1 = new MyList(3);
        l1.Add  ("123");

        Assert.That(l1.GetValue(0), Is.EqualTo("123"));

    }

    
    

    [Test]
    public void MyListGetValue()
    {
        MyList l5 = new MyList(2);
        l5.Add("1");
        l5.Add("2");

        
        Assert.That(l5.GetValue(1), Is.EqualTo("2"));
        Assert.That(l5.count, Is.EqualTo(2));
    }

    [Test]
    public void MyListSetValue()
    {
        MyList l6 = new MyList(2);
        l6.Add("1");
        l6.Add("2");

        l6.SetValue("123", 1);
        Assert.That(l6.GetValue(1), Is.EqualTo("123"));
        Assert.That(l6.count, Is.EqualTo(2));
    }

    [Test]
    public void MyListCollectionInitialiser()
    {
        MyList mylist = new MyList(3)
        {
           "s1", "s2", "s3"
        };
        Assert.That(mylist[1], Is.EqualTo("s2"));
        Assert.That(mylist.count, Is.EqualTo(3));
    }

}
