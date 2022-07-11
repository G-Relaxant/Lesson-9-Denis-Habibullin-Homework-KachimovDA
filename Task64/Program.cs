// 1 variant
/*
Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int number)
{
    if(number == 1)
        return number;
    else
        Console.Write($"{NaturalNumber(number - 1)}, ");

    return number;
}
*/



// 2 variant
Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());
if(number > 0)
{
    ConsoleWriteWithRecursion(number);
    Console.Write(1);
}
else
{
    Console.Write("Inputed incorrect number");
}

void ConsoleWriteWithRecursion(int a)
{
    if(a > 1)
    {
        Console.Write($"{a}, ");
        a--;
        if(a > 1)
        {
            ConsoleWriteWithRecursion(a);
        }
    }   
}