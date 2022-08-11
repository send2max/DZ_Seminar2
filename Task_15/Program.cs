//  Напишите программу, 
//  которая принимает на вход цифру, обозначающую день недели,
//   и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Day_oof(int num)
{
if (number == 6 || number == 7)

    Console.WriteLine($"{number}-> да");
    

else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)

    Console.WriteLine($"{number}-> нет");
else 
Console.WriteLine($"{number}-> неправильный запрос, введите число от 1 до 7");
return number;

}
int result = Day_oof(number);



