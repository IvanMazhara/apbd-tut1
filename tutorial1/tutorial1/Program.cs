internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Tutorial 1");
        int a = 0;
        Console.WriteLine(a);

        int[] arr = { 1, 2, 3, 4, 5 };
        GetAverage(arr);
    }

    static double GetAverage(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i > arr.Length; i++) { 
            sum += arr[i];
        }

        double avg = sum / arr.Length;

        return avg;
    }
}