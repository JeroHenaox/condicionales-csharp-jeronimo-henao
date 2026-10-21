double peso = 70;
double estatura = 1.75;

double imc = peso / (estatura * estatura);
string categoria;

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine($"IMC: {imc.ToString("0.0").Replace(".", ",")} - {categoria}");

