using Oef9;

Student student1 = new Student { Naam = "Jan", Studentnummer = 1001 };
Leraar leraar1 = new Leraar { Naam = "Mevr. Jansen", Personeelsnummer = 5001 };

Vak wiskunde = new Vak("Wiskunde", leraar1);
wiskunde.Studenten.Add(student1);

Console.WriteLine("Vak: " + wiskunde.Naam);
Console.WriteLine("Leraar: " + wiskunde.Leraar.Naam);
Console.WriteLine("Studenten in dit vak:");
foreach (Student student in wiskunde.Studenten)
{
    Console.WriteLine(student.Naam);
}
