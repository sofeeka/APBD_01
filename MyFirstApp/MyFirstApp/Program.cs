// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double getOtherAverage(int[] arr)
{
    double sum = 0;
    foreach (var number in arr)
        sum += number;
    return sum / arr.Length;
}

static double findMax(int[] arr)
{
    int max = arr[0];
    foreach (var number in arr)
        max = Math.Max(max, number);
    return max;
}
