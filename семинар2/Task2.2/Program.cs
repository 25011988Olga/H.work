﻿Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n<100)
Console.Write("Третьей цифры нет");
else
{    
    while(n>1000)
    n=n/10;
    Console.WriteLine(n%10);
}

