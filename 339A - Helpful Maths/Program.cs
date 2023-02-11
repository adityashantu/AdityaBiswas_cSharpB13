namespace _339A___Helpful_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split("+");
            int[] myInts = Array.ConvertAll(s, int.Parse);
            Array.Sort(myInts);

            for (int temp = 0; temp < myInts.Length; temp++)
            {
                if (temp < myInts.Length - 1)
                {
                    Console.Write(myInts[temp].ToString() + "+");
                }
                else
                {
                    Console.WriteLine(myInts[temp].ToString());
                }
            }
        }
    }
}