/*Skriv en funktion där en cirkels radie läses in. Cirkelns diameter, omkrets och area skall beräknas och skrivas ut. (pi = 3.14).*/


double radius;
Console.Write("Ange cirkelns radie: ");
string? input = Console.ReadLine();

if (double.TryParse(input, out radius))
{
    double diameter = 2 * radius;
    double circumference = 2 * 3.14 * radius;
    double area = 3.14 * radius * radius;
    Console.WriteLine($"Cirkeln har radien {radius}, diametern är {diameter}, omkretsen är {circumference} och arean är {area}.");
}
else if (input.Contains('.'))
{
    Console.WriteLine("Du behöver använda , istället för . som decimaltecken.");
}
else
{
    Console.WriteLine("Det där var inget giltigt tal.");
}

