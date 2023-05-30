using unit;

namespace test;

[TestClass]
public class UnitTest1
{
        [TestMethod]
        public void Test_AddMethod()
        {
            Basic bm = new Basic();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            Basic bm = new Basic();
            double res = bm.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            Basic bm = new Basic();
            double res = bm.divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            Basic bm = new Basic();
            double res = bm.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    
}
