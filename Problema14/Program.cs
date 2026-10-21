
double nota = 3.5;

string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota.ToString("0.0").Replace(".", ",")} - {estado}");

