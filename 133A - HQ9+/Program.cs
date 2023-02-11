namespace _133A___HQ9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            foreach (char ch in str)
            {
                if (Equals(ch, 'H') || Equals(ch, 'Q') || Equals(ch, '9'))
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}