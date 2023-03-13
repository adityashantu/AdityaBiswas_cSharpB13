// See https://aka.ms/new-console-template for more information
DateTime day = DateTime.Now;

Console.WriteLine("100 days from today");
Console.WriteLine(day.AddDays(100).DayOfWeek);
Console.WriteLine(day.AddDays(100).ToString("MMMM"));