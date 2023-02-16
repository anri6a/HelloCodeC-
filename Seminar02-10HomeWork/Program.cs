/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

// int firstDigit = number / 100;
// int secondDigit = (number / 10) % 10;
// int thirdDigit = number % 10;

Console.WriteLine("second digit = " + ((number / 10) % 10));
