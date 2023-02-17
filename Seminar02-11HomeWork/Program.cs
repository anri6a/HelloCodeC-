/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("ther is no 3d digit");
else
    while (number >= 999)
        number = number / 10;
//Console.WriteLine(number);
Console.WriteLine($"3d digit {number} is {number % 10}");

