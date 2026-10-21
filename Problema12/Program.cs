bool tieneEmpleo = true;
double ingresoMensual = 3000000;

if (!tieneEmpleo)
{
    Console.WriteLine("Crédito rechazado");
}
else if (ingresoMensual >= 2500000)
{
    Console.WriteLine("Crédito alto aprobado");
}
else
{
    Console.WriteLine("Crédito básico aprobado");
}
