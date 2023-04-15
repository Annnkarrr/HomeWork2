//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ( number < 100)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    if (number > 999)
if (number < 100 || number > 999) 
{
    Console.WriteLine("Число не трехзначное"); 
}
else 
{
    number = number % 10;
    Console.WriteLine($"{number % 10}");
}
    {
        number = number / 10;
        number = number % 10;
        Console.WriteLine($"{number % 10}");
    }
    else
    {
         number = number % 10;
        Console.WriteLine($"{number % 10}");
    }
}
if (number >= 100)
{
    int thirdDigit = {number / 100 % 10};
    Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
}
else
{
    Console.WriteLine("Ошибка! Введено двухзначное или меньше число.");
}*/

int funct(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int thirdDigit(int number)
{
    while (number > 999)
    {
        number = number/10;
    }
    return number % 10;
}

bool proverka(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Ошибка ! ! ! Третьей цифры нет");
        return false;
    }
    return true;
}

int number = funct("Введите число: ");
if (proverka(number))
{
    Console.WriteLine(thirdDigit(number));
}
