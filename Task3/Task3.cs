namespace Task3;

public static class ExtensionMethods
{
    /// <summary>
    /// <para> Отсчитать несколько элементов с конца </para>
    /// <example> new[] {1,2,3,4}.EnumerateFromTail(2) = (1, ), (2, ), (3, 1), (4, 0)</example>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="enumerable"></param>
    /// <param name="tailLength">Сколько элеметнов отсчитать с конца (у последнего элемента tail = 0)</param>
    /// <returns></returns>
    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        if (tailLength < 0)
        {
            throw new IndexOutOfRangeException("tailLenght must be >= 0");
        } 
        
        var result = new List<(T, int?)>();
        if (tailLength == null)
        {
            foreach (var element in enumerable)
            {
                result.Add((element, null));
            }
        }
        else
        {
            var left = enumerable.GetEnumerator();
            var right = enumerable.GetEnumerator();

            int i = 0;
            while (i < tailLength && right.MoveNext())
                i++;
            if (i != tailLength)
            {
                throw new IndexOutOfRangeException("tailLenght is bigger than enumeration size");
            }
            while (right.MoveNext())
            {
                left.MoveNext();
                result.Add((left.Current, null));
            }
            left.MoveNext();
            for (int j = (int) tailLength - 1; j >= 0; --j)
            {
                result.Add((left.Current, j));
                left.MoveNext();
            }
        }
        return result;
    }
}
/*
 * Решение в один проход
 */