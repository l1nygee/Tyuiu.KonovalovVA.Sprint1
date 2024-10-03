using Tyuiu.KonovalovVA.Sprint1.Task3.V4.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void PurchaseAmount()
        {
            DataService ds  = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int quantity = 7;
            double res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Assert.AreEqual(22.75, res);
        }
    }
}