namespace Task3;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        var enumeratedFromTail = array.EnumerateFromTail(5);
        foreach (var pair in enumeratedFromTail)
            Console.Write(pair + " ");
    }
}