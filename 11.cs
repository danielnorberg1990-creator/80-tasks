using System.Globalization;

Console.Write("Ange första talet (både , och . fungerar som decimaltecken): ");
string? rawInput1 = Console.ReadLine()?.Replace(',', '.');

if (!double.TryParse(rawInput1, NumberStyles.Any, CultureInfo.InvariantCulture, out double input1))
{
    Console.WriteLine("Ogiltigt värde angivet.");
    return;
}

Console.Write("Ange andra talet (både , och . fungerar som decimaltecken): ");
string? rawInput2 = Console.ReadLine()?.Replace(',', '.');

if (!double.TryParse(rawInput2, NumberStyles.Any, CultureInfo.InvariantCulture, out double input2))
{
    Console.WriteLine("Ogiltigt värde angivet.");
    return;
}

if (input1 == input2)
{
    Console.WriteLine("Du har matat in samma värde.");
}
else if (input1 > input2)
{
    Console.WriteLine($"{input1}");
}
else
{
    Console.WriteLine($"{input2}");
}