/*Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/
int a = new Random().Next(0, 100);
int b = new Random().Next(0, 100);
if (a > b)
Console.WriteLine(a + " bolshe; " + b + " menshe");
else 
if (a < b)
    Console.WriteLine(a + " menshe; " + b + " bolshe");
else 
    Console.WriteLine(a + " ravno " + b);



