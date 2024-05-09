using System.Diagnostics;

namespace Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n\nGenerateV1()");
            //foreach (int number in GenerateV1())
            //    Console.Write($"  {number}  ");

            //Console.WriteLine("\n\nGenerateV2()");
            //foreach (int number in GenerateV2())
            //    Console.Write($"  {number}  ");

            //yield return an item for the caller each time 
            Console.WriteLine("\n\nGenerateV3()");
            foreach (int number in GenerateV3())
                Console.Write($"  {number}  ");

            Console.ReadKey();
        }
        static IEnumerable<int> GenerateV1()
        {
            List<int> result = [];
            for (int i = 1; i <= 5; i++)
                result.Add(i);
            return result;
        }
        static IEnumerable<int> GenerateV2()
        {
            for (int i = 1; i <= 5; i++)
                yield return i;
        }

        static IEnumerable<int> GenerateV3()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield break;
            yield return 7;
            yield return 8;
            yield return 9;
        }
    }
}
