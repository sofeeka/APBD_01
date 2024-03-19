// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double GetAverage(int[] arr)
{
    double sum = 0;
    foreach (var number in arr)
        sum += number;
    return sum / arr.Length;
} 
