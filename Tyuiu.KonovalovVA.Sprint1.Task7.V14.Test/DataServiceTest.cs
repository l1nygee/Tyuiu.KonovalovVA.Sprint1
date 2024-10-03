using Tyuiu.KonovalovVA.Sprint1.Task7.V14.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 1;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.447, res);
        }
    }
}