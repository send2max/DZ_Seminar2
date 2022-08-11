//  Напишите программу, 
//  которая выводит третью цифру заданного числа или 
//  сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int thirdSecond(int num)
{
    if (num > 99)
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        return num % 10;
    }
    else return -1;

}

int result = thirdSecond(number);

if (result !=-1)
{
    Console.WriteLine($"{number} -> {result}");

}
else Console.Write($"{number} ->третьей цифры нет"); 







