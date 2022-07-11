﻿Console.Write("Input number M: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number N: ");
double n = Convert.ToDouble(Console.ReadLine());
//int ak = 0;
double akkerman = AkkermanFunction(m, n);
Console.WriteLine(akkerman);

double AkkermanFunction(double a, double b)
{
    if(a == 0)
    {
       return n + 1;
    }
    else
    {
        if(a > 0 && b == 0)
        {
            return AkkermanFunction(a - 1, 1);
        }
        else
        {
            return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
        }
    }
}
