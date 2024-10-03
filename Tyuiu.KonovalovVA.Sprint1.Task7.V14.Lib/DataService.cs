using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KonovalovVA.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Pow(2,-x) + ((5*x*x)/3*x*x*x) - Math.Cos(x*x) + Math.Sin(2*x*7), 3);
        }
    }
}
