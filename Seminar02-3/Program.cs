/*is number1 multiple number2*/
Console.WriteLine("enter firstNumber");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter secondNumber");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber % secondNumber == 0)
Console.WriteLine("Multiple Numbers");
else 
    Console.WriteLine("remainder of the division is: " 
                        + firstNumber % secondNumber);


