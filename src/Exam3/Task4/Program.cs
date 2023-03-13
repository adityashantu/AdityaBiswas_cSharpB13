// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Please Enter A String...");

string input = Console.ReadLine();

StringBuilder test = new StringBuilder(input);
for (int i = 0; i < test.Length; i++)
{
    if (test[i] == 'a' || test[i] == 'e' || test[i] == 'i' || test[i] == 'o' || test[i] == 'u')
    {
        test[i] = '-';
    }
}

string output = test.ToString();
Console.WriteLine(output);
