// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"a = { a }" );
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"b = { b }" );
if (a>b)
{
    Console.WriteLine($"Наибольшее число: {a}");
}
else if (a<b)
{
    Console.WriteLine($"Наибольшее число: {b}");
}
else 
{
    Console.WriteLine("Числа равны!");
}


