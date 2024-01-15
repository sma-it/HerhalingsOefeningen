Console.Write("Je geboortejaar: ");
string? geboortejaarInput = Console.ReadLine();

if (geboortejaarInput != null)
{
    int geboortejaar = int.Parse(geboortejaarInput);
    int huidigJaar = DateTime.Now.Year;
    int leeftijd = huidigJaar - geboortejaar;

    Console.WriteLine($" Op het einde van {huidigJaar} zal je {leeftijd} zijn.");
} else
{
    Console.WriteLine("Ongeldige invoer");
}