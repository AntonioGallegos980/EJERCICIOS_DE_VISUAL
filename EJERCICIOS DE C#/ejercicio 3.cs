// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingresa  numeros de alumnos que realizaran el viaje:");
int NA =int.Parse(Console.ReadLine());
double PA;
if (NA>=100)
{
    PA = 65.0;
}
else
{
    if (NA>=50)
    {
        PA = 70.0;
    }
    else
    {
        if (NA>=30)
        {
            PA = 95.0;
        }
        else
        {
            PA = 4000 / NA;
        }
    }
}
double TOT;
TOT= PA * NA;
Console.WriteLine("EL PAGO INDIVIDUAL ES DE :" + PA);
Console.WriteLine("EL PAGO TOTAL ES :" + TOT);