using Oef11;

Product appel = new Product("APL001", "Appel", 0.50, 100);

appel.Aanvullen(50);
appel.Verkopen(20);

Console.WriteLine($" Een {appel.Naam} kost {appel.Prijs}.");

Console.WriteLine(appel.ToonInformatie());
