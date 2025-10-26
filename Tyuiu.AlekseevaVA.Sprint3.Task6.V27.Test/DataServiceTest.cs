using Tyuiu.AlekseevaVA.Sprint3.Task6.V27.Lib;

namespace Tyuiu.AlekseevaVA.Sprint3.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 14;
            int stopValue = 20;


            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 129;

            Assert.AreEqual(wait, res);
        }
    }
}
