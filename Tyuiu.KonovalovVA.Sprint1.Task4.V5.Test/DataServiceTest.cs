using Tyuiu.KonovalovVA.Sprint1.Task4.V5.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            double x = -2.0;
            double y = 9.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}