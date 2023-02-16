int number = new Random().Next(10, 99);
Console.WriteLine("number = "+ number);
//number = 66;
int maxDigit = -1;
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) 
    maxDigit = firstDigit;
else if (firstDigit < secondDigit) 
    maxDigit = secondDigit;
else 
    Console.WriteLine("digits are equal");

Console.WriteLine("max digit = " + maxDigit);





