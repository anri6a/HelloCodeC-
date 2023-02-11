// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter user name");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша") 
{
    Console.WriteLine("it's pleasure " + userName);
} 
else 
{
    Console.WriteLine("hello " + userName);
}
