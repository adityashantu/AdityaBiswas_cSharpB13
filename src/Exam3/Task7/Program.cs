// See https://aka.ms/new-console-template for more information
List<object> human = new List<object>();


human.Add(new { Name = "Aditya", Age = 25 });
human.Add(new { Name = "Zawad", Age = 28 });
human.Add(new { Name = "Joyeeta", Age = 23 });
human.Add(new { Name = "Trisha", Age = 22 });
human.Add(new { Name = "Ovi", Age = 24 });
human.Add(new { Name = "Tahu", Age = 21 });



foreach (var person in human)
{
    Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age;
}
