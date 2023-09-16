Console.WriteLine("Введите x :");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y :");
double y = Convert.ToDouble(Console.ReadLine());
double tmp = x;
if (x > y)
{
    Console.WriteLine("x больше");
    x = y * x * 2;
    y = (tmp + y) / 2;
}
else
{
    Console.WriteLine("y больше");
    x = (x + y) / 2;
    y = y * tmp * 2;
    
}
Console.WriteLine($"x = {x}");
Console.WriteLine($"y = {y}");