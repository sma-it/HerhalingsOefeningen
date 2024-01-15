
Console.Write("Je naam: ");
string? naam = Console.ReadLine();

Console.Write("Je leeftijd: ");
string? leeftijdInput = Console.ReadLine();

if (int.TryParse(leeftijdInput, out int result))
{
    Console.WriteLine($"Hallo {naam}. Je bent {result} jaar oud.");
} else
{
    Console.WriteLine("Ongeldige leeftijd.");
}
