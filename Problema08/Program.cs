char letra = 'z';

if (!char.IsLetter(letra) || letra < 'a' || letra > 'z')
{
    Console.WriteLine("No es una letra");
}
else if ("aeiou".Contains(letra))
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}
