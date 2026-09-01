/*Läs in ett heltal motsvarande svenska kronor och skriv ut motsvarande värde i pund respektive dollar. Antag att kursen är : 1 dollar = 6 kr, 1 pund = 10 kr.*/

int kronor;
int pund;
int dollar;

Console.Write("Ange ett heltal i svenska kronor: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out kronor))
{
    pund = kronor / 10;
    dollar = kronor / 6;
    Console.WriteLine($"{kronor} kr motsvarar {pund} pund och {dollar} dollar.");
}
else
{
    Console.WriteLine("Det där var inget giltigt heltal.");
}