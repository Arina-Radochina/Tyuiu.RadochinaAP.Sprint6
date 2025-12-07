using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                // F(x) = sin(x)/(x+1.2) + cos(x) * 7x - 2
                // Проверка деления на ноль: x + 1.2 = 0
                double denominator = x + 1.2;

                if (Math.Abs(denominator) < 0.000001)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double fraction = Math.Sin(x) / denominator;
                    double product = Math.Cos(x) * 7 * x;
                    valueArray[i] = Math.Round(fraction + product - 2, 2);
                }
            }

            return valueArray;
        }
    }
}
       
