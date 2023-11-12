using System;
class Program
{
    static void PrintArray(string[] array)
    {
        int leng = array.Length;
        for (int i = 0; i < leng; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Clear();
        string[] array = { "Hello", "2", "world", ":-)" };
        //string[] array = {"1234", "1567", "-2", "computer science"};
        //string[] array = {"Russia", "Denmark", "Kazan"};
        int wordlength = 3;
        int k = 0;
        int leng = array.Length;
        string[] arr = new string[leng];

        for (int i = 0; i < leng; i++)
        {
            if (array[i].Length <= wordlength)
            {
                arr[i] = array[i];
                k++;
            }
        }

        Console.WriteLine("Исходный массив");
        PrintArray(array);

        Console.WriteLine("Итоговый массив");
        if (k != 0) PrintArray(arr);
        else Console.WriteLine("array is null");
    }
}
