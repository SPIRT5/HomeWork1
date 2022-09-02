
Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

for (int i = 1; i <= number; i++) {
    if ((i % 2) == 0)  
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine("");