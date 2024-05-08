using System.Collections;

namespace Yield_project;
public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        Console.WriteLine("\n\nusing for loop");
        for (int i = 0; i < numbers.Count; i++)
            Console.Write(numbers[i]+"\t");

        Console.WriteLine("\n\nusing foreach");
        foreach (int number in numbers)
            Console.Write(number+"\t");

        //complier dosen't understand foreach , it translate it to IL intermediate languge to the beyond example 
        Console.WriteLine("\n\nusing custom foreach");
        Foreach(numbers);
        
    }
    static void Foreach<T>(IEnumerable<T> source)
    {
        IEnumerator<T> enumerator = source.GetEnumerator();
        try
        {
            while (enumerator.MoveNext())
            {
                T item;
                item = enumerator.Current;
                Console.Write(item);
            }
        }
        finally
        {
            enumerator.Dispose();
        }
    }
}
