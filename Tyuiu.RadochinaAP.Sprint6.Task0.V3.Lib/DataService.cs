using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task0.V3.Lib
{
    public class DataService : ISprint6Task0V3
    {
        public double Calculate(int x)
        {
            double numerator = 4 * Math.Pow(x, 3);
            double denominator = Math.Pow(x, 3) - 1;

            if (Math.Abs(denominator) < 0.000001)
            {
                throw new DivideByZeroException("Деление на ноль!");
            }

            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}
       