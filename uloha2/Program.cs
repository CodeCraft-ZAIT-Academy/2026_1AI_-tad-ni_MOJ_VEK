DateTime dnes = DateTime.Now;
Console.WriteLine("zadaj rok");
string Rok = Console.ReadLine();
int rok = int.Parse(Rok);
int vek = dnes.Year - rok;
Console.WriteLine("Máš"+ vek + "rokov");