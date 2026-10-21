using System.Globalization;

double peso = 7;
int tarifa = 0;

if (peso <= 0)
{
    Console.WriteLine("Peso inválido");
}
else if (peso < 1)
{
    tarifa = 8000;
}
else if (peso < 5)
{
    tarifa = 15000;
}
else if (peso < 20)
{
    tarifa = 32000;
}
else
{
    tarifa = 60000;
}

if (peso > 0)
{
    string tarifaTexto = tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"));
    Console.WriteLine($"Tarifa: ${tarifaTexto}");
}