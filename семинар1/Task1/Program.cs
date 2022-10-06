Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("первое число max,второе min");
}
if(a<b)
{
    Console.WriteLine("первое число min,второе max");
}
if(a==b)
{
    Console.WriteLine("числа равны,введите новую пару чисел");
}
