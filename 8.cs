/*Skriv en funktion som beräknar och skriver ut arean och omkretsen av en rektangel. Rektangelns sidor ska läsas in.*/

double lenght;
double width;

Console.Write("Ange rektangelns längd: ");
string? inputLength = Console.ReadLine();  

Console.Write("Ange rektangelns bredd: ");
string? inputWidth = Console.ReadLine();  

if (double.TryParse(inputLength, out lenght) && double.TryParse(inputWidth, out width))
{
    double area = lenght * width;
    double perimeter = 2 * (lenght + width);
    Console.WriteLine($"Rektangelns area är {area} och omkretsen är {perimeter}.");
}
else if (inputLength.Contains('.') || inputWidth.Contains('.'))
{
    Console.WriteLine("Du behöver använda , istället för . som decimaltecken.");
}
else
{
    Console.WriteLine("Det där var inget giltigt tal.");
}