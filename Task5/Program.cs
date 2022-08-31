using System.Reflection;

namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");
        // custom code
    }

    static void TransformToElephant()
    {
        // option 1
        // Console.WriteLine("Слон");
        // Console.SetOut(TextWriter.Null);
        
        // option 2
        unsafe
        {
            fixed (char* ptr = "Муха")
            {
                char* move1 = ptr;
                string elephant = "Слон";
                int i = 0;
                while (*move1 != '\0')
                {
                    *move1 = elephant[i];
                    ++i;
                    move1++;
                }
            }
        }
    }
}