namespace _791A___Bear_and_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int limak = Convert.ToInt32(str[0]);
            int bob = Convert.ToInt32(str[1]);
            int count = 0;

            while (limak <= bob)
            {
                limak *= 3;
                bob *= 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}