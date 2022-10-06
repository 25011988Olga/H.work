Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число; ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max) max = b;
{
    Console.WriteLine("Второе число max");
}
if(c>max) max = c;
{
    Console.WriteLine("Третье число max");
}