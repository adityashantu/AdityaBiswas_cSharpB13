namespace _118A___String_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            string output = "";

            for (int temp = 0; temp < s.Length; temp++)
            {
                if (Equals(s[temp], 'a') || Equals(s[temp], 'e') || Equals(s[temp], 'i') || Equals(s[temp], 'o') || Equals(s[temp], 'u') || Equals(s[temp], 'y'))
                {
                    continue;
                }
                else
                {
                    output += "." + s[temp].ToString();
                }
            }
            Console.WriteLine(output);
        }
    }
}