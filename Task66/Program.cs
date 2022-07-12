// Вариант с рекурсией

Console.Write("Input number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

if (m < n)
{
    sum = SumCalculateNbigM(m, n, sum);
    Console.Write(n);
    sum = sum + n;
    Console.WriteLine();
    Console.WriteLine($"Sum = {sum}");
}
else
{
    if(m == n)
    {
        Console.WriteLine($"Numbers should having different values");
    }
    else
    {
        sum = SumCalculateMbigN(m, n, sum);
        Console.Write(m);
        sum = sum + m;
        Console.WriteLine();
        Console.WriteLine($"Sum = {sum}");
    }    
}

int SumCalculateNbigM(int a, int b, int s)
{
    if(a < b)
    {
        Console.Write($"{a}, ");
        s = s + a;
        a++;
        if(a < b)
        {
            s = SumCalculateNbigM(a, b, s);
            return s;
        }
        else
        {
            return s;
        }
    }
    return s;   
}
int SumCalculateMbigN(int a, int b, int s)
{
    if(b < a)
    {
        Console.Write($"{b}, ");
        s = s + b;
        b++;
        if(b < a)
        {
            s = SumCalculateMbigN(a, b, s);
            return s;
        }
        else
        {
            return s;
        }
    }
    return s;    
}




// Вариант 2
/*
Console.Write("Input number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

if (m < n)
{
    while(m < n)
    {
        sum = sum + m;
        m++;
    }
    sum = sum + m;
    Console.WriteLine();
    Console.WriteLine($"Sum = {sum}");
}
else
{
    if(m == n)
    {
        Console.WriteLine($"Numbers should having different values");
    }
    else
    {
        while(n < m)
        {
            sum = sum + n;
            n++;
        }
        sum = sum + n;
        Console.WriteLine();
        Console.WriteLine($"Sum = {sum}");
    }   
}
*/