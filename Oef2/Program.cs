Console.Write("Voer je naam in: ");
string? naam = Console.ReadLine();

Console.Write("Aantal begroetingen: ");
string? count = Console.ReadLine();

if (naam != null && count != null)
{
    int num = int.Parse(count);

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Hallo {naam}");
    }
} else
{
    Console.WriteLine("Ongeldige input");
}


