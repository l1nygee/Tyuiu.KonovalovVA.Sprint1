using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KonovalovVA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            bool ans = false;
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] == value[0])
                {
                    ans = true;
                }
            }
            return ans;
        }
    }
}
