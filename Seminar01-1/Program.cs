/*Программа принимающая на вход 3х значное число и на выходе 
выдает вторую цифру этого числа*/
Console.WriteLine("enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//int number = 879;
int number = new Random().Next(100, 1000);
int firstPosition=0;
int secondPosition=0;
int thirdPosition=0;

if (number > 99 && number < 1000)
{
firstPosition = number / 100;       // 567/100 = 5
thirdPosition = number % 10;        // 567%10 = 7
secondPosition = (number / 10) % 10; //567/10 = 56%10
Console.WriteLine("First = " + firstPosition + 
                    " second = " + secondPosition + 
                    " third = " + thirdPosition);
}
else 
{
Console.WriteLine("Invalid number - try again");
}

