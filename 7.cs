/*Skriv en funktion som beräknar vad du ska betala för en tank bensin. Indata är antal liter, pris per liter och eventuell rabatt i procent. Utdata är priset som du ska betala*/


double pricePerLiter;
double liters;
double totalCost;



Console.Write("Ange antal liter: ");
liters = Convert.ToDouble(Console.ReadLine());

Console.Write("Ange pris per liter: ");
pricePerLiter = Convert.ToDouble(Console.ReadLine());

Console.Write("Ange rabatt i procent: ");
double discountAmount = Convert.ToDouble(Console.ReadLine());

double CalculateFuelCost(double liters, double pricePerLiter, double discountPercent)
{
    totalCost = liters * pricePerLiter;
    discountPercent = totalCost * (discountPercent / 100);
    return totalCost - discountAmount;
}

Console.WriteLine($"Total kostnad efter rabatt: {CalculateFuelCost(liters, pricePerLiter, discountAmount)} kr");

