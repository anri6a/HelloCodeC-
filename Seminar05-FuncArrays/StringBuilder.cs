using System.Text;
StringBuilder sb = new();
for (int i = 0; i < 1_000_000; i++)
{
    sb.Append(i + "\n");
}
if (File.Exists("File.txt"))
{
    string s = File.ReadAllText("File.txt").Replace("\n", "");
    System.Console.WriteLine("+");
    System.Console.WriteLine(s.Substring(10, 20));
}
else
{
    File.WriteAllText("file.txt", sb.ToString(), Encoding.UTF8);
}

