using System.Globalization;

double compra = 250000;
bool clienteFrecuente = true;
double descuento;

if (compra >= 500000)
{
    descuento = 15;
}
else if (compra >= 200000)
{
    descuento = 10;
}
else if (compra >= 100000)
{
    descuento = 5;
}
else
{
    descuento = 0;
}

if (clienteFrecuente && compra >= 100000)
{
    descuento += 5;
}

double total = compra - (compra * descuento / 100);
CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.WriteLine($"Valor de la compra: ${compra.ToString("N0", cultura)}");
Console.WriteLine($"Descuento total: {descuento:0}%");
Console.WriteLine($"Total a pagar: ${total.ToString("N0", cultura)}");
