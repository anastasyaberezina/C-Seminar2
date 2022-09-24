//Выводит случайное трехзначное число и удаляет вторую цифру этого числа
//Кажется, решение с семинара покажет ПЕРВЫЕ 2 цифры!!!


int number = new Random().Next(100, 1000);

int num1 = number / 100; //1е число
int num2 = num1 % 10;    //2е число
int num3 = number - (num1*100); 
int result =num3-(num3%10);
int result2 = result / 10;
int result3 = result - num3;


Console.WriteLine(number);

Console.WriteLine(result2);

Console.WriteLine($"Получилась цифра {num1}{result3}");


//Решение с семинара 

//int number = new Random().Next(100, 1000);

//int number1 = number / 100; 
//int number2 = num1 % 10;    

//int result = number1*10 + number2;

//Console.WriteLine(result);