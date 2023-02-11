namespace _116A___Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tramStops = 0;
            int output = 0;
            int num = Convert.ToInt32(Console.ReadLine());

            for (int temp = 0; temp < num; temp++)
            {
                string[] str = Console.ReadLine().Split(' ');
                tramStops = tramStops - Convert.ToInt32(str[0]) + Convert.ToInt32(str[1]);
                if (tramStops > output)
                {
                    output = tramStops;
                }
            }
            Console.WriteLine(output);
        }
    }
}