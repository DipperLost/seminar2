Console.WriteLine("Введите трехзначное число: ");
int numberС = Convert.ToInt32(Console.ReadLine());
int numberA = numberС % 100;
int numberB = numberA / 10;
Console.WriteLine(numberB);
