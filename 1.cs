/*Skriv en funktion som skriver ut kvadraten på ett tal som läses in. Kvadrat är talet multiplicerat med sig själv.*/


Console.Write("Ange ett tal: ");
string? input = Console.ReadLine();

if (double.TryParse(input, out double number))
{
    Console.WriteLine($"Du skrev {number}. Kvadraten är {number * number}.");
}
else if (input.Contains('.'))
{
    Console.WriteLine("Du behöver använda , istället för . som decimaltecken.");
}
else
{
    Console.WriteLine("Det där var inget giltigt tal.");
}
