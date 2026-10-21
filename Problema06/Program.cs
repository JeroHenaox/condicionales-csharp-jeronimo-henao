
string jugador1 = "piedra";
string jugador2 = "tijera";

if (jugador1 == jugador2)
{
    Console.WriteLine("Empate");
}
else if (
    (jugador1 == "piedra" && jugador2 == "tijera") ||
    (jugador1 == "tijera" && jugador2 == "papel") ||
    (jugador1 == "papel" && jugador2 == "piedra"))
{
    Console.WriteLine("Gana el jugador 1");
}
else
{
    Console.WriteLine("Gana el jugador 2");
}
