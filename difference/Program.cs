using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 4, 20, -2, 50, 55, 30, 25, 15, 19, 17 };
        int[] arr2 = { 100, 37, 29, 14, 35, 150, 145, -6, 9, 10 };
        var result = Calculate(arr1, arr2);
        Console.WriteLine(result.Item1);
        Console.WriteLine($"[{result.Item2[0]}, {result.Item2[1]}]");
    }

    static Tuple<int, int[]> Calculate(int[] arr1, int[] arr2)
    {
        int min = int.MaxValue;
        int[] indexes = new int[2];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                int dif = Math.Abs(arr1[i] - arr2[j]);
                if (dif < min)
                {
                    min = dif;
                    indexes[0] = arr1[i];
                    indexes[1] = arr2[j];
                }
            }
        }
        return new Tuple<int, int[]>(min, indexes);
    }
}
