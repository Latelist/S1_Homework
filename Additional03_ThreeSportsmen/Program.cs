// На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

Console.WriteLine("Input first sportsman's height: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second sportsman's height: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third sportsman's height: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (c > a)
    {
        Console.WriteLine("{0}, {1}, {2}", c, a, b);
    }
    else if (c > b)
    {
        Console.WriteLine("{0}, {1}, {2}", a, c, b);
    }
    else
    {
        Console.WriteLine("{0}, {1}, {2}", a, b, c);
    }
}
else
{
    if (c > b)
    {
        Console.WriteLine("{0}, {1}, {2}", c, b, a);
    }
    else if (c > a)
    {
        Console.WriteLine("{0}, {1}, {2}", b, c, a);
    }
    else
    {
        Console.WriteLine("{0}, {1}, {2}", b, a, c);
    }
}