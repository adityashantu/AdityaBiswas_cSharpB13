internal class Program
{
    private static void Main(string[] args)
    {
        string s = Console.ReadLine();
        List<char> l = new List<char>();

        int c = 0;

        foreach (char ch in s)
        {
            if (!l.Contains(ch))
            {
                l.Add(ch);
            }
        }
        if (l.Count % 2 != 0)
        {
            Console.WriteLine("IGNORE HIM!");
        }
        else
        {
            Console.WriteLine("CHAT WITH HER!");
        }
    }
}