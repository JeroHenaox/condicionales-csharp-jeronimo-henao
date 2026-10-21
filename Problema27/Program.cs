string dia = "jueves";
bool esEstudiante = true;
int precio;

if (dia == "martes")
{
    precio = 7000;
}
else if (dia == "sabado" || dia == "domingo")
{
    precio = 15000;
}
else if (
    dia == "lunes" ||
    dia == "miercoles" ||
    dia == "jueves" ||
    dia == "viernes")
{
    precio = esEstudiante ? 9000 : 12000;
}
else
{
    precio = 0;
    Console.WriteLine("Día inválido");
}

if (precio > 0)
{
    Console.WriteLine($"Precio de la boleta: ${precio:N0}");
}
