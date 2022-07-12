Console.Write("Input number M: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number N: ");
double n = Convert.ToDouble(Console.ReadLine());
double ak = 0;
double akkerman = AkkermanFunction(m, n);
Console.WriteLine($"Answer: {akkerman}");

double AkkermanFunction(double a, double b)
{
    if(a == 0)
    {
       return ak = b + 1;
    }
    else
    {
        if(a > 0 && b == 0)
        {
            return ak =  AkkermanFunction(a - 1, 1);
        }
        else
        {
            if(a > 0 && b > 0)
            {
                return ak = AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
            }
            else
            {
                return ak;
            }
        }
    }
}
