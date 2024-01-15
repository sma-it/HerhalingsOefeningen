using Oef7;

List<Evenement> evenementen = new();

int actie;

while (true)
{
    Console.WriteLine("Kies een actie: (1) Evenement toevoegen, (2) Lijst bekijken, (3) Zoeken, (4) Sorteren, (5) Stoppen");
    string? input = Console.ReadLine();

    if (input == null)
    {
        break;
    }

    actie = int.Parse(input);

    switch (actie)
    {
        case 1: voegToe(); break;
        case 2: toonLijst(); break;
        case 3: zoek(); break;
        case 4: sorteer(); break;
        case 5: stop(); break;
    }
}

void voegToe()
{
    Console.WriteLine("Voer de naam van het evenement in:");
    string? naam = Console.ReadLine();
   
    Console.WriteLine("Voer de datum van het evenement in (dd-mm-yyyy):");
    DateTime datum;
    bool valid = DateTime.TryParse(Console.ReadLine(), out datum);

    if (naam != null && valid)
    {
        evenementen.Add(new Evenement { Naam = naam, Datum = datum });
    }
}

void toonLijst()
{
    foreach (Evenement evt in evenementen)
    {
        if (evt.Datum >= DateTime.Today)
        {
            Console.WriteLine($"{evt.Naam} op {evt.Datum.ToShortDateString()}");
        }
    }
}

void zoek()
{
    Console.WriteLine("Voer de naam van het evenement in:");
    string? zoekNaam = Console.ReadLine();

    if (zoekNaam == null) return;
    
    var gevondenEvenement = evenementen.FirstOrDefault(e => e.Naam.Contains(zoekNaam));
    if (gevondenEvenement != null)
    {
        Console.WriteLine($"Evenement gevonden: {gevondenEvenement.Naam} op {gevondenEvenement.Datum.ToShortDateString()}");
    }
    else
    {
        Console.WriteLine("Evenement niet gevonden.");
    }
}

void sorteer()
{
    evenementen = evenementen.OrderBy(e => e.Datum).ToList();
    Console.WriteLine("Evenementen gesorteerd op datum.");
}

void stop()
{
    Environment.Exit(0);
}