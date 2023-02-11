namespace _58A___Chat_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] hello = { 'h', 'e', 'l', 'l', 'o' };
            int hello_count = 0;

            foreach (char ch in str)
            {
                if (Equals(ch, hello[hello_count]))
                {
                    hello_count++;
                }
                if (hello_count == 5)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}