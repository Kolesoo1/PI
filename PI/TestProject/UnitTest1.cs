using PITEST;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(PITEST.Program.CheckVieta(-0.5, -2, 2, 5, 2));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(!PITEST.Program.CheckVieta(1, -2, 2, 5, 2));
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(PITEST.Program.CheckVieta(-1, -2, 3, 9, 6));
        }
    }
}