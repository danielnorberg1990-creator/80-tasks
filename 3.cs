/*Skriv en funktion som läser in antal timmar, beräknar och skriver ut hur mycket det blir omvandlat till minuter resp sekunder.*/

double sekunder;
double minuter;
double timmar;

Console.WriteLine("Ange antal timmar: ");
timmar = Convert.ToDouble(Console.ReadLine());

minuter = timmar * 60;
sekunder = minuter * 60;

if (timmar < 0)
{
    Console.WriteLine("Du kan inte ange ett negativt tal.");
}
else if (timmar == 0)
{
    Console.WriteLine("Du kan inte ange 0 timmar.");
}
else if (timmar > 24)
{
    Console.WriteLine("Du kan inte ange mer än 24 timmar.");
}
else
{
    Console.WriteLine($"Antal timmar: {timmar}");
    Console.WriteLine($" motsvarar {minuter} minuter eller {sekunder} sekunder.");
}