namespace _546A___Soldier_and_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str= Console.ReadLine().Split(' ');
            int cost = Convert.ToInt32(str[0]);
            int own_dollar = Convert.ToInt32(str[1]);
            int num = Convert.ToInt32(str[2]);
            int output = 0;

            for (int temp = 1; temp <= num; temp++)
            {
                output += (cost * temp);

            }
            if (output - own_dollar <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(output - own_dollar);
            }
        }
    }
}