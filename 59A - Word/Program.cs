namespace _59A___Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int count = 0;
            foreach (char ch in word)
            {
                if (65 <= Convert.ToInt32(ch) && Convert.ToInt32(ch) <= 90)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(word.ToUpper());
            }
            else
            {
                Console.WriteLine(word.ToLower());
            }
        }
    }
}