// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese la duración de la llamada en minutos: ");
int duracionLlamada = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el día de la semana (domingo, lunes, etc.): ");
string diaSemana = Console.ReadLine().ToLower();

Console.Write("Ingrese el turno de la llamada (matutino o vespertino): ");
string turnoLlamada = Console.ReadLine().ToLower();

double costoTotal = 0;

if (duracionLlamada <= 5)
{
    costoTotal = duracionLlamada * 1.00;
}
else if (duracionLlamada <= 8)
{
    costoTotal = 5.00 + (duracionLlamada - 5) * 0.80;
}
else if (duracionLlamada <= 10)
{
    costoTotal = 7.40 + (duracionLlamada - 8) * 0.704;
}
else
{
    costoTotal = 9.50 + (duracionLlamada - 10) * 0.50;
}


double impuesto = 0;

if (diaSemana == "domingo")
{
    impuesto = costoTotal * 0.03;
}
else if (diaSemana == "laboral")
{
    if (turnoLlamada == "matutino")
    {
        impuesto = costoTotal * 0.15;
    }
    else if (turnoLlamada == "vespertino")
    {
        impuesto = costoTotal * 0.10;
    }
}


double totalPagar = costoTotal + impuesto;

Console.WriteLine($"Costo de la llamada: {costoTotal:C2}");
Console.WriteLine($"Impuesto: {impuesto:C2}");
Console.WriteLine($"Total a pagar: {totalPagar:C2}");

Console.ReadKey();