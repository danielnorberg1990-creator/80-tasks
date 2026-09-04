double tal1;
double tal2;

Console.Write("Ange första talet ");
tal1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ange andra talet ");
tal2 = Convert.ToDouble(Console.ReadLine());

if (tal1 == tal2 * 2 || tal2 == tal1 * 2)
{
    Console.WriteLine($"För stort");
}
else
{Console.WriteLine($"Du har angett talen {tal1} och {tal2}. ");}