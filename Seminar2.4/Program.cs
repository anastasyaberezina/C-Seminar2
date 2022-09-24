// Принимает число и проверяет кратность на 7 и 23.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((number%7 == 0)&&(number%23 == 0))
{
    Console.WriteLine($"Число {number} является кратным 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} НЕ является кратным 7 и 23");
}