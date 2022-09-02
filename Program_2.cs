
Console.Write("Введите первое число: ");
string numberStrFirst = Console.ReadLine();
Console.Write("Введите второе число: ");
string numberStrSecond = Console.ReadLine();
Console.Write("Введите третье число: ");
string numberStrThird = Console.ReadLine();
int numberFirst = int.Parse(numberStrFirst);
int numberSecond = int.Parse(numberStrSecond);
int numberThird = int.Parse(numberStrThird);
int max = 0;

if (numberFirst > max)  
{
    max = numberFirst;
}
if (numberSecond > max)  
{
    max = numberSecond;
}
if (numberThird > max)  
{
    max = numberThird;
}

Console.WriteLine("Максимальное число: " + max);
