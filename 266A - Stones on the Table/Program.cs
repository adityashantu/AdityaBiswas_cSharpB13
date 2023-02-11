namespace _266A___Stones_on_the_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            int count = 0;

            for (int x = 0; x < num - 1; x++)
            {
                if (s[x] == s[x + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}