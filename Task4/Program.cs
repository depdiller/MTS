namespace Task4;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new[] {7, 5, 3, 2, 8, 3};
        int sortFactor = 5;
        int max = array.Max();
        var result = Helper.Sort(array, sortFactor, max);
        foreach (var element in result)
        {
            Console.Write(element + " ");
        }
    }
}