
Console.Write("Ange första talet. ");
double tal1 = Convert.ToDouble(Console.ReadLine());

while (tal1 == 0)
{
    Console.WriteLine($"Talet kan inte vara noll.");
    Console.Write("Ange första talet. ");
    tal1 = Convert.ToDouble(Console.ReadLine());
}


Console.Write("Ange andra talet. För att kontrollera om det är delbart med första talet. ");
double tal2 = Convert.ToDouble(Console.ReadLine());

while (tal2 == 0)
{
    Console.WriteLine($"Talet kan inte vara noll.");
    Console.Write("Ange andra talet. ");
    tal2 = Convert.ToDouble(Console.ReadLine());
}

if (tal1 % tal2 == 0)
{
    Console.WriteLine($"Talet {tal2} är delbart med {tal1}.");
}
else
{
    Console.WriteLine($"Talet {tal2} är inte delbart med {tal1}.");
}