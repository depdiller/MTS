namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch
        {
            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }
    }

    static void FailProcess()
    {
        // 
        // int[] array = {1, 2};
        // array[3] = 5;

        //
        // System.IO.File.ReadAllText("unknownFile.txt");

        //
        // List<int> list = null;
        // list.Add(2);
        
        //
        // object o = "10";
        // int x = (int)o;
        
        //
        // var list = new List<int> {1, 2};
        // var query = list.Where(x => x > 5).First();
        
        //
        // string val = new string('r', int.MaxValue);
        
        //
        // string[] arr1 = {"hello", "world"};
        // object[] arr2 = arr1;
        // arr2[0] = 1;
        
        //
        // int res = 1 / Int32.Parse("0");

        //
        // throw new Exception("exception");
    }
}