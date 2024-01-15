Console.Write("hoogte: ");
string? hoogteInput = Console.ReadLine();

Console.Write("breedte: ");
string? breedteInput = Console.ReadLine();

if (hoogteInput != null && breedteInput != null)
{
    int hoogte = int.Parse(hoogteInput);
    int breedte = int.Parse(breedteInput);  

    int omtrek = (hoogte + breedte) * 2;
    int oppervlak = (hoogte * breedte);

    Console.WriteLine($"Omtrek: {omtrek}");
    Console.WriteLine($"Oppervlak: {oppervlak}");
}

