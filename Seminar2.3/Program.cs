// Принимает 2 числа и выводит, является ли второе число кратным первому.

Console.Write("Введите двузначное число: ");
int number = int.Parse(Console.ReadLine());
int number1 = number / 10;
int number2 = number % 10;

if (number1%number2==0)
{
    Console.WriteLine($"Число {number2} является кратным числу {number1}");
}
else
{
    Console.WriteLine($"Число {number2} НЕ является кратным числу {number1}");
}

