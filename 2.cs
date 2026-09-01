/*En försäljare har delvis prestationslön. Han får 8000 kr per månad i grundlön och 9% av försäljningssumman. Skriv en funktion som beräknar lönesumman under en period. Försäljningssumman ska läsas in.*/

int pay = 8000;
int procent = 9;


Console.Write("Ange försäljningssumman: ");
string? input = Console.ReadLine();
Console.WriteLine();
if (double.TryParse(input, out double sales))
{
    double totalPay = pay + (sales * procent / 100);
    Console.WriteLine($"Försäljningssumman är {sales}. Lönesumman är {totalPay}.");
}
else if (input.Contains('.'))
{
    Console.WriteLine("Du behöver använda , istället för . som decimaltecken.");
}
else
{
    Console.WriteLine("Det där var inget giltigt tal.");
}