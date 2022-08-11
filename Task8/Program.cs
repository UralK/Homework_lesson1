Console.WriteLine("Введите число");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N = {N}");
int count = 0;
int a = 0;
while (count < N)
{
    a = count + 1;
    if (a % 2 == 0)
    Console.WriteLine(a);
    count ++;
    
}

