internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] words = new string[n];

        for (int x = 0; x < n; x++)
        {
            words[x] = Console.ReadLine();
        }

        for (int x = 0; x < n; x++)
        {
            if (words[x].Length > 10)  //use string.Length to get string length
            {
                Console.WriteLine(words[x][0].ToString() + (words[x].Length - 2) + words[x][words[x].Length - 1].ToString());
                //just combining 2 char, adds their ascii code. So, i had to convert the chars to string before combining them. 
            }
            else
            {
                Console.WriteLine(words[x]);
            }
        }
    }
}