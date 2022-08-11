// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"a = {a}");
Console.WriteLine("Введите второе число");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"b = {b}");
Console.WriteLine("Введите третье число");
int c = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"c = {c}");
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"max = {max}");
