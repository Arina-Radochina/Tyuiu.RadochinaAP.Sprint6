using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.RadochinaAP.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] valueArray = new double[length];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
            {
                double denominator = 2 * x - 2;

                if (Math.Abs(denominator) < 0.000001)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double numerator = 2 + Math.Cos(x);
                    double fraction = numerator / denominator;
                    valueArray[i] = Math.Round(4 - 2 * x + fraction, 2);
                }
            }

            return valueArray;
        }

        public void SaveToFile(string path, double[] valueArray, int startValue, int stopValue)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("X\tF(x)");
                for (int i = 0; i < valueArray.Length; i++)
                {
                    writer.WriteLine($"{startValue + i}\t{valueArray[i]}");
                }
            }
        }
    }
}