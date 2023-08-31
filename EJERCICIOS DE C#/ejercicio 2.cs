// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese tipo de uva (A o B): ");
char tipoDeUva = Console.ReadLine()[0];
Console.Write("Ingrese tamaño de uva (1 o 2): ");
int tamañoDeUva = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese precio inicial por kilo de uva: ");
double precioInicial = Convert.ToDouble(Console.ReadLine());

// Calcular ganancia
double ganancia = precioInicial;

if (tipoDeUva == 'A')
{
    if (tamañoDeUva == 1)
    {
        ganancia += 204;
    }
    else if (tamañoDeUva == 2)
    {
        ganancia += 304;
    }
}
else if (tipoDeUva == 'B')
{
    if (tamañoDeUva == 1)
    {
        ganancia -= 304;
    }
    else if (tamañoDeUva == 2)
    {
        ganancia -= 504;
    }
}


Console.WriteLine($"La ganancia obtenida es: {ganancia}");

Console.ReadKey();