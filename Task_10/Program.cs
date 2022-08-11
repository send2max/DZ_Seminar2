//  Напишите программу, 
//  которая принимает на вход трёхзначное число и 
//  на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());


int showSecond(int num)
{
    int number1 = number / 10;
    int nov = number1 % 10;
    return nov;
}

int result = showSecond(number);
Console.WriteLine($"{number}-> {result}");

