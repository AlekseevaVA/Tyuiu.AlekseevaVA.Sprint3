using Tyuiu.AlekseevaVA.Sprint3.Task3.V22.Lib;

namespace Tyuiu.AlekseevaVA.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "tbtbbb dsfbg bbg";
            char chr = 'b';

            double res = ds.GetMaxCharCount(value, chr);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
