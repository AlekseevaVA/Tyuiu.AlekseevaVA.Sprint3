using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlekseevaVA.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                double y = Math.Abs(denominator) < 1e-10 ? 0 : Math.Round((2 * x + 6) / denominator - 3, 2);

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
