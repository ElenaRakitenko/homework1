// объявляем переменные
int a, b, c, max;

Console.WriteLine("Задача 2");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

// запрашиваем ввод значений
Console.WriteLine("Введите первое число");
a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32 (Console.ReadLine());

// проверяем условия
if (a == b)
{
    Console.WriteLine("числа равны");
}
else
{
    if ( a > b )
    {
        max = a;
        Console.WriteLine("max = a = "+ max);
    }
    else
    {
        max = b;
        Console.WriteLine("max = b = "+ max);
    };
}

  
Console.WriteLine("");   
Console.WriteLine("");  
Console.WriteLine("Задача 4");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

//запрашиваем ввод значений

Console.WriteLine("Введите первое число");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
c=Convert.ToInt32(Console.ReadLine());

// проверка корректности ввода данных

if ((a==b)&(a==c)&(b==c))
{
    Console.WriteLine("Заданные три числа равны");
    }
else
    {
    if ((a==b)^(b==c)^(a==c))
    {
        Console.WriteLine("Два из заданных чисел равны");
    }
}         

// проверяем условия

if ((a>b)&(a>c))
{
    max = a;
    Console.WriteLine("max = a = "+ max);
} 
else
{
    if ((b>a)&(b>c))
    {
        max=b;
        Console.WriteLine("max = b = "+ max);
    }
    else
    {
        if ((c>a)&(c>b))
        {
            max=c;
            Console.WriteLine("max = c = "+ max);
        }
    }
}

Console.WriteLine("");   
Console.WriteLine("");  
Console.WriteLine("Задача 6");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

// запрашиваем ввод значений
Console.WriteLine("Введите число");
a = Convert.ToInt32 (Console.ReadLine());
if ((a%2)==0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");   
};   

Console.WriteLine("");   
Console.WriteLine("");  
Console.WriteLine("Задача 8");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

// запрашиваем ввод значений
Console.WriteLine("Введите число");
a = Convert.ToInt32 (Console.ReadLine());
b = 0;

Console.WriteLine("Четные числа от нуля до " + a + ":");
do 
{
    b++;
    if ((b%2)==0)
    {
        Console.WriteLine(b);
    }
} while (b < a);

Console.WriteLine("Программа HomeWork №1 завершена.");
return 0;
