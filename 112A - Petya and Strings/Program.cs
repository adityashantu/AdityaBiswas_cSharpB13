namespace _112A___Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            char[] firstArr = firstString.ToCharArray();
            char[] secondArr = secondString.ToCharArray();



            for (int temp = 0; temp < firstArr.Length; temp++)
            {
                if (Char.ToLower(firstArr[temp]) < Char.ToLower(secondArr[temp]))
                {
                    Console.WriteLine(-1);
                    return;
                }
                else if (Char.ToLower(firstArr[temp]) > Char.ToLower(secondArr[temp]))
                {
                    Console.WriteLine(1);
                    return;
                }
            }
            Console.WriteLine(0);
        }
    }
}