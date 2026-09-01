/*Skriv en funktion som läser in tre tal och beräknar och skriver ut summan samt medelvärdet av de tre talen.*/

double tal1;
double tal2;
double tal3;
double summa;
double medelvärde;

Console.WriteLine("Ange tre tal: ");
tal1 = Convert.ToDouble(Console.ReadLine());
tal2 = Convert.ToDouble(Console.ReadLine());
tal3 = Convert.ToDouble(Console.ReadLine());

summa = tal1 + tal2 + tal3;
medelvärde = summa / 3;

if (tal1 < 0 || tal2 < 0 || tal3 < 0)
    {
        Console.WriteLine("Du kan inte ange ett negativt tal.");
    }
   else
    {
        Console.WriteLine($"Talen är: {tal1}, {tal2}, {tal3}");
    }
    Console.WriteLine($"Summa: {summa}");
    Console.WriteLine($"Medelvärde: {medelvärde}");
