Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int C = N / 100;
if (C >= 1)
{
    while (N / 100 <= 9 & N / 100 >= 1)
    {
        Console.WriteLine(N % 10);
        N = N / 10;
    }
}
else Console.WriteLine("третьей цифры нет");
