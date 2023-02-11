namespace _263A___Beautiful_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = 0;
            for (int temp = 0; temp < 5; temp++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int temp1 = 0; temp1 < 5; temp1++)
                {
                    if (str[temp1].Equals("1"))
                    {
                        if (temp != 2)
                        {
                            output += Math.Abs(2 - temp);
                        }
                        if (temp1 != 2)
                        {
                            output += Math.Abs(2 - temp1);
                        }
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}