
using LearningLib;
namespace LearningLib.Tests;

public class Tests
{

    [Test]

    public void MyListAdd()
    {
        MyList l1 = new MyList(3);
        l1.Add  ("123", 0);

        Assert.That(l1.GetValue(0), Is.EqualTo("123"));

    }
    [Test]
    public void MyListDelete()
    {
        MyList l2 = new MyList(4);
        l2.Add("1", 0);
        l2.Add("2", 1);
        l2.Add("3", 2);
        l2.Add("4", 3);

        l2.Delete(1, 2);

        Assert.That(l2.GetValue(1), Is.EqualTo(null));
        Assert.That(l2.count, Is.EqualTo(2));
    }
   
 
    
 
    [Test]
    public void MyListGetValue()
    {
        MyList l5 = new MyList(2);
        l5.Add("1", 0);
        l5.Add("2", 1);

        
        Assert.That(l5.GetValue(1), Is.EqualTo("2"));
        Assert.That(l5.count, Is.EqualTo(2));
    }

    [Test]
    public void MyListSetValue()
    {
        MyList l6 = new MyList(2);
        l6.Add("1", 0);
        l6.Add("2", 1);

        l6.SetValue("123", 1);
        Assert.That(l6.GetValue(1), Is.EqualTo("123"));
        Assert.That(l6.count, Is.EqualTo(2));
    }

}
