using Oef10;

Bankrekening mijnRekening = new Bankrekening("BE0123456789", "Jan de Vries", 1000);
mijnRekening.Storten(500);
mijnRekening.Opnemen(200);

Console.WriteLine($"Dit is de rekening van {mijnRekening.Eigenaar}");
Console.WriteLine($"Het saldo is: {mijnRekening.ToonSaldo()}");