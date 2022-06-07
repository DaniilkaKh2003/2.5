using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("количество элементов массива = ");
            int N = int.Parse(Console.ReadLine());
            Random R = new Random();
            int[] A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = R.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("\nНовый массив:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                int a = R.Next(1, mas.Length + 1);
                if (!mas.Contains(a)) mas[i] = a;
                else i--;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[mas[i] - 1]);
            }
        }
    }
}
