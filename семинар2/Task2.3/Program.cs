Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n<1||n>7)
n = Convert.ToInt32(Console.ReadLine());
if(n>5)
Console.WriteLine("выходной");
if (n<6)
Console.WriteLine("будний день"); 
