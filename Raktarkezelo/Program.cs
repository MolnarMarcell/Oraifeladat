using Raktarkezelo;

RaktarElem elem = new RaktarElem("Cikk1", 10);

elem.Bevetelezes(5);

elem.Kiadas(3);

double bruttoAr = RaktarElem.BruttoArSzamitas(100);

Console.WriteLine(bruttoAr);