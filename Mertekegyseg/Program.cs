using Mertekegyseg;

double meter = Atvalto.KmBolMeter(5);
Console.WriteLine(meter);

Atvalto Atvaltas = new Atvalto();

Atvaltas.Szorzo = 400;

double eredmeny = Atvaltas.EgyediAtvaltas(5);
Console.WriteLine(eredmeny);