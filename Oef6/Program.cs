List<string> namen = new List<string>();
int actie;

while (true)
{
    Console.WriteLine("Kies een actie: (1) Naam toevoegen, (2) Namen tonen, (3) Naam zoeken, (4) Naam verwijderen, (5) Stoppen");
    string? input = Console.ReadLine();

    if (input == null)
    {
        break;
    }

    actie  = int.Parse(input);

    switch(actie)
    {
        case 1: voegToe(); break;
        case 2: toonNamen(); break;
        case 3: zoekNaam(); break;
        case 4: verwijderNaam(); break;
        case 5: stop(); break;
    }
}

void voegToe()
{
    Console.Write("Geef een naam in: ");
    string? input = Console.ReadLine();

    if (input != null)
    {
        namen.Add(input.Trim());
    }
}

void toonNamen()
{
    foreach(var naam in namen)
    {
        Console.WriteLine(naam);
    }
}

void zoekNaam()
{
    Console.Write("Voer de te zoeken naam in: ");
    string? zoekNaam = Console.ReadLine();

    if (zoekNaam == null)
    {
        return;
    }

    if (namen.Contains(zoekNaam))
    {
        Console.WriteLine(zoekNaam + " is gevonden.");
    }
    else
    {
        Console.WriteLine(zoekNaam + " is niet gevonden.");
    }
}

void verwijderNaam()
{
    Console.Write("Voer de te verwijderen naam in: ");
    string? verwijderNaam = Console.ReadLine();

    if (verwijderNaam == null) { return; }

    if (namen.Remove(verwijderNaam))
    {
        Console.WriteLine(verwijderNaam + " is verwijderd.");
    }
    else
    {
        Console.WriteLine(verwijderNaam + " is niet gevonden.");
    }
}

void stop()
{
    Environment.Exit(0);
}