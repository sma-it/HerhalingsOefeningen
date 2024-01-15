List<string> films = new List<string>();
int actie;

while (true)
{
    Console.WriteLine("Kies een actie: (1) Film toevoegen, (2) Lijst bekijken, (3) Film zoeken, (4) Stoppen");
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
        case 4: stop(); break;
    }
}

void voegToe()
{
    Console.WriteLine("Voer de titel van de film in:");
    string? film = Console.ReadLine();
    if (film == null) return;

    films.Add(film);
}

void toonLijst()
{
    Console.WriteLine("Je favoriete films:");
    foreach (string film in films)
    {
        Console.WriteLine(film);
    }
}

void zoek()
{
    Console.WriteLine("Voer de titel van de film in die je zoekt:");
    string? zoekFilm = Console.ReadLine();
    if (zoekFilm == null) return;

    if (films.Contains(zoekFilm))
    {
        Console.WriteLine(zoekFilm + " is gevonden in je lijst.");
    }
    else
    {
        Console.WriteLine(zoekFilm + " is niet gevonden in je lijst.");
    }
}

void stop()
{
    Environment.Exit(0);
}