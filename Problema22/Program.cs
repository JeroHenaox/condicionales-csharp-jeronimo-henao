int numero1 = 12;
int numero2 = 4;
char operador = '*';

try
{
    int resultado;

    switch (operador)
    {
        case '+':
            resultado = numero1 + numero2;
            break;
        case '-':
            resultado = numero1 - numero2;
            break;
        case '*':
            resultado = numero1 * numero2;
            break;
        case '/':
            if (numero2 == 0)
            {
                throw new Exception("No se puede dividir entre cero");
            }

            resultado = numero1 / numero2;
            break;
        default:
            throw new Exception("Operador no soportado");
    }

    Console.WriteLine($"{numero1} {operador} {numero2} = {resultado}");
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

