string rol = "admin";
int hora = 2;

if (hora < 0 || hora > 23)
{
    Console.WriteLine("Acceso denegado");
}
else if (rol == "admin")
{
    Console.WriteLine("Acceso permitido");
}
else if (rol == "instructor" && hora >= 6 && hora <= 21)
{
    Console.WriteLine("Acceso permitido");
}
else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso denegado");
}
