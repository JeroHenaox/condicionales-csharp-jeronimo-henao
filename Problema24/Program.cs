
int dia = 3;
string resultado;

switch (dia)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        resultado = "Día hábil";
        break;
    case 6:
    case 7:
        resultado = "Fin de semana";
        break;
    default:
        resultado = "Día inválido";
        break;
}

Console.WriteLine(resultado);

