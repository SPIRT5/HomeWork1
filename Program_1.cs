
Console.Write("Введите первое число: ");
string numberStrFirst = Console.ReadLine();
Console.Write("Введите второе число: ");
string numberStrSecond = Console.ReadLine();
int numberFirst = int.Parse(numberStrFirst);
int numberSecond = int.Parse(numberStrSecond);

if (numberFirst > numberSecond)  
{
    Console.WriteLine("Первое число " + numberFirst + " является больше второго " + numberSecond);
}
else
{
    Console.WriteLine("Второе число " + numberSecond + " является больше первого " + numberFirst);
}