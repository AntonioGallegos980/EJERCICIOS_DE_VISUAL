// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingresa EL numeros PERSONAS:");
int NP = int.Parse(Console.ReadLine());
double TOT;
if (NP > 300)
{
    TOT = NP * 75;

}
else
{
    if (NP > 200)
    {
        TOT = NP * 85;
    }
    else
    {
        TOT = NP * 95;
    }
}
Console.WriteLine("EL TOTAL ES :" + TOT);