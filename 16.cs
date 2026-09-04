
double summa = 0;
int procent = 0;
string? input = "";

do
{
    Console.Write("Ange summa: ");
    input = Console.ReadLine();

    if (!double.TryParse(input, out summa) || summa <= 0)
    {
        Console.WriteLine($"Du har inte angett en giltig summa.");
    }
}
while (summa <= 0);

    if (summa >= 1000)
{
    procent = 10;
    Console.WriteLine($"Du får {procent}% rabatt på din summa på {summa} kr. Totala beloppet att betala blir {summa - (summa * procent / 100)} kr.");
}
else if (summa > 0 && summa < 1000)
{
    Console.WriteLine($"Du får ingen rabatt på din summa på {summa} kr då du handlat för mindre än 1000 kr. Totala beloppet att betala blir {summa - (summa * procent / 100)} kr.");
}
