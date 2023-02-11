namespace _617A___Elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int location = Convert.ToInt32(Console.ReadLine());
            int step_count = 0;

            while (location != 0)
            {
                if (location >= 5)
                {
                    step_count++;
                    location -= 5;
                }
                else if (location >= 4)
                {
                    step_count++;
                    location -= 4;
                }
                else if (location >= 3)
                {
                    step_count++;
                    location -= 3;
                }
                else if (location >= 2)
                {
                    step_count++;
                    location -= 2;
                }
                else if (location >= 1)
                {
                    step_count++;
                    location -= 1;
                }
            }
            Console.WriteLine(step_count);
        }
    }
}