// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = (a%100) / 10;

if (a > 99 && a < 1000)
    Console.WriteLine($"Вторая цифра вашего числа {x}");
else 
    Console.WriteLine("введите трехзначное число");  