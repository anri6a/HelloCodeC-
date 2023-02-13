/*из 2х введенных чисел определяем является ли первое 
квадратом второго*/

        double x;
        double y;
        
        Console.WriteLine("введи х");
        x = inputValue();
        Console.WriteLine("введи y");
        y = inputValue();
        if (x == y * y)
        {
            Console.WriteLine("kvadrat");
        }
        else
        {
            Console.WriteLine("ne kvadrat");
        }
    
     static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }


