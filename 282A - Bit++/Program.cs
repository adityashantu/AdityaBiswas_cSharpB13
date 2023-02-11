namespace _282A___Bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            int count = Convert.ToInt32(Console.ReadLine());
            for (int temp = 0; temp < count; temp++)
            {
                string operation = Console.ReadLine();
                if (operation == "++X" || operation == "X++")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        }
    }
}