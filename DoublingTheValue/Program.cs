using System;

namespace DoublingTheValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubling the Value!");
            Console.WriteLine("-------------------");
            int[] array = ArrayUtility.GetArrayFromUserInput();
            ArrayUtility.DoublingValue(array);
            Console.ReadLine();
        }
    }
}
