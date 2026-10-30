using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 4, 6, 8, 10};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("Сумма элементов массива: " + sum);

        }
    }
}