/*Sambandet mellan Fahrenheit och Celsius grader ges av formeln F=9C / 5 + 32.
Konstruera en funktion där en temperatur i Fahrenheit läses in och motsvarande temperatur i Celsius skrivs ut.*/

double fahrenheit;

Console.Write("Ange temperaturen i Celsius: ");
string? celciusInput = Console.ReadLine();

if (double.TryParse(celciusInput, out double celcius))
{
    fahrenheit = 9 * celcius / 5 + 32;
    Console.WriteLine($"Temperaturen i Fahrenheit är: {fahrenheit}");
}
else if (celciusInput.Contains('.'))
{
    Console.WriteLine("Du behöver använda , istället för . som decimaltecken.");
}
else if (celciusInput.Contains(""))
{
    Console.WriteLine("Du har inte matat in något värde. ");
}
else
{
    Console.WriteLine("Det där var inget giltigt tal.");
}



