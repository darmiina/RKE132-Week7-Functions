// Kirjutage programm, mis teisendab Fahrenheiti kraadi Celsiuse järgi ja vastupidi.
// * Programm võimaldab kasutajal valida, kas teisendada väärtuse Celciusesse või Farenheiti.
// *Kui kasutaja on oma valiku teinud, programm küsib sisendit, teostab arvutusi ja kuvab tulemuse.
// * fahrenheit = (celsius * 9) / 5 + 32;
// * celsius = (fahrenheit - 32) * 5/9;

Console.WriteLine("Vali järgmine valik:");
Console.WriteLine("1. Fahrenheit - Celsius");
Console.WriteLine("2. Celsius - Fahrenheit");

int Choice = Int32.Parse(Console.ReadLine());

double temperature;

switch (Choice)
{
    case 1:
        Console.WriteLine("Sisesta temperatuur:");
        temperature = double.Parse(Console.ReadLine());
        ConverToCelsius(temperature);
        break;
    case 2:
        Console.WriteLine("Sisesta temperatuur:");
        temperature = double.Parse(Console.ReadLine());
        ConvertToFahrenheit(temperature);
        break;
    default:
        Console.WriteLine("Vale väärtus.");
        break;
}
static void ConvertToFahrenheit(double celsius)
{
    double convertedTemperature = (celsius * 9 / 5) + 32; 
    Console.WriteLine($"Temperatuur on: {convertedTemperature}");
}

static void ConverToCelsius(double fahrenheit)
{
    double convertedTemperature = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"Temperatuur on: {convertedTemperature}");
}


