using Tyuiu.KonovalovVA.Sprint1.Task1.V28.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}