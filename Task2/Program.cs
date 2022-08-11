Console.WriteLine("Введите первое число");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"a = { a }" );
Console.WriteLine("Введите второе число");
int b = Convert.ToInt16(Console.ReadLine());
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


