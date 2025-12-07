using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {

                double denominator = Math.Cos(x) - 2 * x;

                if (Math.Abs(denominator) < 0.000001)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double numerator = 2 * x - 3;
                    double fraction = numerator / denominator;
                    double result = fraction + 5 * x - Math.Sin(x);
                    valueArray[i] = Math.Round(result, 2);
                }
            }

            return valueArray;
        }
    }
}