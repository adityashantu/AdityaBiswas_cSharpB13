// See https://aka.ms/new-console-template for more information


List<Tuple<string, int>> human = new List<Tuple<string, int>>();



human.Add(Tuple.Create("Aditya", 25));
human.Add(Tuple.Create("Zawad", 28));
human.Add(Tuple.Create("Joyeeta", 23));
human.Add(Tuple.Create("Trisha", 22));
human.Add(Tuple.Create("Ovi", 24));
human.Add(Tuple.Create("Tahu", 21));





foreach (Tuple<string, int> person in human)
{
    Console.WriteLine("Name: {0}, Age: {1}", person.Item1, person.Item2);
}

