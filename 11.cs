Console.WriteLine("Введите минуты :");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите a :");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b :");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c :");
double c = Convert.ToDouble(Console.ReadLine());
double res;
if (m <= a)
{
    res = b;

}
else
{
 
    res = (m - a) * c + b;
}
Console.WriteLine($"В это месяце вы заплатите: {res}");
