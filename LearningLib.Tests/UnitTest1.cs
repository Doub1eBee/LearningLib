
using LearningLib;
namespace LearningLib.Tests;

public class Tests
{

    [Test]

    public void TestInsert()
    {
        MyList l1 = new MyList(3);
        l1.Insert("123", 1);

        Assert.That(l1.GetValue(1), Is.EqualTo("123"));

    }
    [Test]
    public void TestDelete()
    {
        MyList l2 = new MyList(4);
        l2.Insert("1", 1);
        l2.Insert("2", 2);
        l2.Insert("3", 3);
        l2.Insert("4", 4);

        l2.Delete(1, 2);

        Assert.That(l2.GetValue(1), Is.EqualTo("1"));
        Assert.That(l2.count, Is.EqualTo(2));
    }
    [Test]
    public void TestInsertToEnd()
    {
        MyList l3 = new MyList(0);

        l3.InsertToEnd("1");
        Assert.That(l3.GetValue(1), Is.EqualTo("1"));
        Assert.That(l3.count, Is.EqualTo(1));
    }
    [Test]
    public void TestDeleteFromEnd()
    {
        MyList l4 = new MyList(2);
        l4.Insert("1",1);
        l4.Insert("2",2);

        l4.DeleteFromEnd();
        Assert.That(l4.GetValue(1), Is.EqualTo("1"));
        Assert.That(l4.count, Is.EqualTo(1));
    }
    [Test]
    public void TestGetValue()
    {
        MyList l5 = new MyList(2);
        l5.Insert("1", 1);
        l5.Insert("2", 2);

        
        Assert.That(l5.GetValue(2), Is.EqualTo("2"));
        Assert.That(l5.count, Is.EqualTo(2));
    }

    [Test]
    public void TestSetValue()
    {
        MyList l6 = new MyList(2);
        l6.Insert("1", 1);
        l6.Insert("2", 2);

        l6.SetValue("123", 2);
        Assert.That(l6.GetValue(2), Is.EqualTo("123"));
        Assert.That(l6.count, Is.EqualTo(2));
    }

}
