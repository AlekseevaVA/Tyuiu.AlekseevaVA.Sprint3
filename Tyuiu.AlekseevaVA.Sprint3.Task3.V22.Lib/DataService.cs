using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlekseevaVA.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {
            int maxCount = 0;
            int currentCount = 0;

            foreach (char ch in value)
                if (ch == 'b')
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                    currentCount = 0;

                }
            if (currentCount > maxCount)
                maxCount = currentCount;

            return maxCount;
        }
    }
}
