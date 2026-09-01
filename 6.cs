/*Skriv en funktion som beräknar funktionen ax3 + 7 och skriver ut resultatet. Variablerna a och x ska läsas in.*/



double BeräknaVärde(double a, double x)
{
    return a * Math.Pow(x, 3) + 7;
}

void KörBeräkning()
{
    Console.Write("Ange värdet för a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ange värdet för x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    double resultat = BeräknaVärde(a, x);

    Console.WriteLine($"Resultatet av funktionen {a}x^3 + 7 när x = {x} är: {resultat}");
}

KörBeräkning();