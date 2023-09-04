// See https://aka.ms/new-console-template for more information
Console.WriteLine("coloque su sueldo:");
int sueldo =int.Parse(Console.ReadLine());
Console.WriteLine("coloque cuantos hijos tiene:");
int hijos =int.Parse(Console.ReadLine());
Console.WriteLine("que categoria es usted:");
Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
Console.WriteLine("D");
char categoria1 = char.Parse(Console.ReadLine());
double suel, suel1, suel2, total, hijo1;
switch (categoria1)
{
    case 'A':
        suel = (sueldo * (0.25)) + sueldo;
        hijo1 = hijos * 0.025;
        suel1 = (suel * hijo1) + suel;
        if (suel1 > 2000)
        {
            suel2 = (suel1 * 0.03);
            total = suel1 - suel2;
            Console.WriteLine("su sueldo actual sera de " + total);
        }
        else
        {
            Console.WriteLine("su sueldo actual sera de " + suel1);
        }
        break;
    case 'B':
        suel = (sueldo * (0.20)) + sueldo;
        hijo1 = hijos * 0.025;
        suel1 = (suel * hijo1) + suel;
        if (suel1 > 2000)
        {
            suel2 = (suel1 * 0.03);
            total = suel1 - suel2;
            Console.WriteLine("su sueldo actual sera de " + total);
        }
        else
        {
            Console.WriteLine("su sueldo actual sera de " + suel1);
        }
        break;
    case 'C':
        suel = (sueldo * (0.15)) + sueldo;
        hijo1 = hijos * 0.025;
        suel1 = (suel * hijo1) + suel;
        if (suel1 > 2000)
        {
            suel2 = (suel1 * 0.03);
            total = suel1 - suel2;
            Console.WriteLine("su sueldo actual sera de " + total);
        }
        else
        {
            Console.WriteLine("su sueldo actual sera de " + suel1);
        }
        break;
    case 'D':
        suel = (sueldo * (0.10)) + sueldo;
        hijo1 = hijos * 0.025;
        suel1 = (suel * hijo1) + suel;
        if (suel1 > 2000)
        {
            suel2 = (suel1 * 0.03);
            total = suel1 - suel2;
            Console.WriteLine("su sueldo actual sera de " + total);
        }
        else
        {
            Console.WriteLine("su sueldo actual sera de " + suel1);
        }
        break;
}
