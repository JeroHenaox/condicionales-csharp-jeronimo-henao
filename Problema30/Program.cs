using System.Globalization;

double nota1 = 85;
double nota2 = 78;
double nota3 = 92;

double promedio = (nota1 + nota2 + nota3) / 3;
string letra;
string retroalimentacion;

if (promedio >= 90)
{
    letra = "A";
    retroalimentacion = "Desempeño excelente";
}
else if (promedio >= 80)
{
    letra = "B";
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 70)
{
    letra = "C";
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 60)
{
    letra = "D";
    retroalimentacion = "Aprobado, refuerza los temas";
}
else
{
    letra = "F";
    retroalimentacion = "Debe presentar plan de mejoramiento";
}

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.WriteLine(
    $"Promedio: {promedio.ToString("0.0", cultura)} | Letra: {letra} | {retroalimentacion} | {estado}"
);

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}
