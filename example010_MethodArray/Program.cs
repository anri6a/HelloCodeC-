int [] array = {1, 44, 32, 44, 59, 68, 70, 8};

int n = array.Length;
int find = 44;
int index = 0;
while (index < n) 
    {
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
     
    }
