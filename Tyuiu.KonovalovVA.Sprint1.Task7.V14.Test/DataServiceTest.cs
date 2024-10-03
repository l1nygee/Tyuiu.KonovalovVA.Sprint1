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
            double x = 5;
            double y = 5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(-0.889, res);
        }
    }
}