using NUnit.Framework;
using LearningLib;

namespace LearningLib.Tests
{
    public class TestsMyList1
    {
        [Test]
        public void Foreach_Without_IEnumerable()
        {
            MyList<float> floatList = new MyList<float>(3)
           {
               1f, 25f, 3.5f
           };
            bool isPassed = false;
            for (float i = 0; i < floatList.count; i++)
            {
                isPassed = true;
            }
            Assert.IsTrue(isPassed);
        }

        [Test]
        public void Foreach_Method()
        {
            bool isPassed = false;  
            MyList<float> floatList = new MyList<float>(3)
           {
               1f, 25f, 3.5f
           };
            foreach (float f in floatList)
            {
                isPassed = true;
            }
            Assert.IsTrue(isPassed);
        }
    }
}