namespace Task2;
using System.Globalization;

class Program
{
    static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

    class Number
    {
        readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public override string ToString()
        {
            return _number.ToString(_ifp);
        }

        public static string operator +(Number number, string s)
        {
            var parsedValue = Int32.Parse(s);
            return (number._number + parsedValue).ToString();
        }
    }

    static void Main(string[] args)
    {
        int someValue1 = -123;
        int someValue2 = 5;

        string result = new Number(someValue1) + someValue2.ToString(_ifp);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}