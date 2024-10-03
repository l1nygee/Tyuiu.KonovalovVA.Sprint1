using Tyuiu.KonovalovVA.Sprint1.Task6.V11.Lib;
namespace Tyuiu.KonovalovVA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckeFirstLetterRepetition()
        {
            DataService ds = new DataService();
            string value = "abbaksdna";
            bool res = ds.CheckeFirstLetterRepetition(value);
            Assert.AreEqual(true, res);
        }
    }
}