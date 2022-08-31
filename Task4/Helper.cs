namespace Task4;

public class Helper
{
    /// <summary>
    /// Возвращает отсортированный по возрастанию поток чисел
    /// </summary>
    /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
    /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось
    /// число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
    /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
    /// <returns>Отсортированный по возрастанию поток чисел.</returns>
    public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
    {
        int[] possibleValues = new int[maxValue + 1];
        var result = new List<int>();
        int reachLowerBoarder = 0;
        foreach (var value in inputStream)
        {
            int lowBorder = value - sortFactor;
            possibleValues[value]++;
            while (reachLowerBoarder < lowBorder)
            {
                while (possibleValues[reachLowerBoarder]-- > 0)
                    result.Add(reachLowerBoarder);
                reachLowerBoarder++;
            }
        }

        for (int i = 0; i < possibleValues.Length; ++i)
        {
            while (possibleValues[i]-- > 0)
                result.Add(i);
        }

        return result;
    }
}
/*
 * Time Complexity - O(n)
 * Space Complexity - O(maxValue), worst case - int[2000]
 */