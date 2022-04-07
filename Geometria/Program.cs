
//valore base e altezza che l'utente inserirà.
using Geometria;

Console.WriteLine("inserisci base del rettangolo");
int baseInputUtente = int.Parse(Console.ReadLine());

Console.WriteLine("inserisci altezza del triangolo");
int altezzaInputUtente = int.Parse(Console.ReadLine());

rettangolo mioRettangolo = new rettangolo(baseInputUtente, altezzaInputUtente);

mioRettangolo.StampaRettangoloConsole();