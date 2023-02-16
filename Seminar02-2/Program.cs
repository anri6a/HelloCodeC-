/*Del 2d digit from Random(xxx)*/
int number = new Random().Next(100, 1000);
Console.WriteLine("number = " + number);
int firstDigit = number / 100;
int secondDigit = (number % 100) / 10;
int thirdDigit = (number % 100) % 10;
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine("result = " + result);
