Console.Write("Mata in ett tal utan decimaler för att kontrollera ifall numret är jämnt : ");
int tal = Convert.ToInt32(Console.ReadLine());

if (tal % 2 == 0)
{
    Console.WriteLine($"Talet {tal} är jämnt.");
}
else
{
    Console.WriteLine($"Talet {tal} är inte jämnt.");
}