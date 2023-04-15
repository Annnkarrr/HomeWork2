// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
    if ( day == 2)
    {
        Console.WriteLine("Вторник");
    }
        if (day == 3)
        {
            Console.WriteLine("Среда");
        }
            if (day == 4)
            {
                Console.WriteLine("Четверг");
            }
                if (day == 5)
                {
                    Console.WriteLine("Пятница");
                }
                    if (day == 6)
                    {
                        Console.WriteLine("Суббота");
                    }
                        if (day == 7)
                        {
                            Console.WriteLine("Воскресенье");
                        }
else
{
    Console.WriteLine("Такого дня недели не существует");
}