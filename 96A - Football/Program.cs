namespace _96A___Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;

            for (int temp = 1; temp < s.Length; temp++)
            {
                if (count == 6)
                {
                    break;
                }
                if (Equals(s[temp], s[temp - 1]))
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            if (count == 6)
            {
                Console.WriteLine("YES");
                return;
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}