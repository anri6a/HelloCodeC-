public class MethodsCW
{
    public static string[] ArrayToChar(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            char[] arr = array[i].ToCharArray();
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr.Length > 3) array[i] = "";
            }
        }
        return array;
    }
    
}


