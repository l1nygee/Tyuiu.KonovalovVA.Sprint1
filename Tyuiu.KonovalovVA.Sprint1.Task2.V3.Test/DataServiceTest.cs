using Tyuiu.KonovalovVA.Sprint1.Task2.V3.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertHourToMin()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(120, res);
        }
    }
}