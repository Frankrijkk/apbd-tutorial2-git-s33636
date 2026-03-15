// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
StatisticsHelper helper = new StatisticsHelper(6, 8);
helper.printStatistics();
int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 6, 7, 67 };
Console.WriteLine(helper.calculateAverage(arr));

class StatisticsHelper
{
    private int x;
    private int y;

    public StatisticsHelper(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void printStatistics()
    {
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(".");
            for (int k = 0; k < y; k++)
            {
                Console.WriteLine("/");
            }
            Console.WriteLine("\n");
        }
    }

    public double calculateAverage(int[] values)
    {
        int l = values.Length;
        double sum = 0;
        for (int i = 0; i < l; i++)
        {
            sum += values[i];
        }
        return sum / l;
    }

    public double calculateMax(int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max) max= values[i];
        }

        return max;
    }
}

