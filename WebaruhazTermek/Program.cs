using WebaruhazTermek;

Termek pozitivTermek = new Termek("Pozitív termék", 100, 10);
Console.WriteLine($"Név: {pozitivTermek.Nev}, Egységár: {pozitivTermek.Egysegar}, Készlet: {pozitivTermek.Keszlet}");
Termek NegativTermek = new Termek("Negatív termék", -50, -5);
Console.WriteLine($"Név: {NegativTermek.Nev}, Egységár: {NegativTermek.Egysegar}, Készlet: {NegativTermek.Keszlet}");