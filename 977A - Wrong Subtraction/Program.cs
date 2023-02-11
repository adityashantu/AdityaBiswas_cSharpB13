namespace _977A___Wrong_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int num = Convert.ToInt32(s[0]);

            for (int temp = Convert.ToInt32(s[1]); temp > 0; temp--)
            {
                if (num % 10 == 0)
                {
                    num /= 10;
                }
                else
                {
                    num--; 
                }
            }
            Console.WriteLine(num);
        }
    }
}