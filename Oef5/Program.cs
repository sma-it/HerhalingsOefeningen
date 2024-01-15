List<int> favorieteNummers = new List<int>();

int nummer;
while (true)
{
    string? input = Console.ReadLine();
    if (int.TryParse(input, out nummer))
    {
        favorieteNummers.Add(nummer);
    }
    else
    {
        break;
    }
}

Console.WriteLine("Je favoriete nummers zijn:");
foreach (var n in favorieteNummers)
{
    Console.WriteLine(n);
}
