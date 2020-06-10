using NUnit.Framework;
using Assignment_1;
namespace Tests
{

    public class Tests
    {
        Rectangle rectangle = null;
        [SetUp]
        public void Setup()
        {
            rectangle = new Rectangle();
        }

        [Test]
        public void TestSetLength()
        {
            
            int result = rectangle.SetLength(5);
            int expected = 5;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestGetLength()
        {
            rectangle.SetLength(5);
            int result = rectangle.GetLength();
            int expected = 5;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestSetWidth()
        {
            int result = rectangle.SetWidth(4);
            int expected = 4;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestGetWidth()
        {
            rectangle.SetWidth(4);
            int result = rectangle.GetWidth();
            int expected = 4;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestGetPerimeter()
        {
            rectangle.SetLength(5);
            rectangle.SetWidth(4);
            int result = rectangle.GetPerimeter();
            int expected = 18;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestGetArea()
        {
            
            rectangle.SetLength(5);
            rectangle.SetWidth(4);
            int result = rectangle.GetArea();
            int expected = 20;
            Assert.AreEqual(expected, result);
        }
    }
}