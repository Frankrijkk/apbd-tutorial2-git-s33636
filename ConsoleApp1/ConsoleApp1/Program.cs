// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
class StatisticsHelper
{
    private int x;
    private int y;

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
}

