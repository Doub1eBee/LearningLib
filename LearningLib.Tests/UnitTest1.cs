
using LearningLib;
namespace LearningLib.Tests;

public class Tests
{

    [Test]

    public void TestAdd()
    {
        Assert.That(MathMethod.Add(-5, 5), Is.EqualTo(20));

    }
    [Test]
    public void Test2()
    {

        Assert.That(MathMethod.Add(0, 0), Is.EqualTo(0));
    }
    [Test]
    public void Test3()
    {

        Assert.That(MathMethod.Add(1, 9), Is.EqualTo(10));
    }
}
public class Test2
{
    [TestCase(0, 0, 0)]
    [TestCase(1, 1, 2)]
    [TestCase(0, 9, 9)]
    [TestCase(9, 0, 9)]

    public void Test(int a, int b, int expected)
    {
        Assert.That(MathMethod.Add(a, b), Is.EqualTo(expected));
    }
}
