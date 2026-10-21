EstadoSemaforo estado = EstadoSemaforo.Amarillo;

switch (estado)
{
    case EstadoSemaforo.Rojo:
        Console.WriteLine("Deténgase");
        break;
    case EstadoSemaforo.Amarillo:
        Console.WriteLine("Precaución, prepárese para detenerse");
        break;
    case EstadoSemaforo.Verde:
        Console.WriteLine("Avance");
        break;
}
enum EstadoSemaforo
{
    Rojo,
    Amarillo,
    Verde
}