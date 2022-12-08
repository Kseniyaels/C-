// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine() ?? "";
int num = Convert.ToInt32(number);


if (num <= 99)
{
    Console.WriteLine("Данное число не является трехзначным");
}
if ((num > 99) & (num < 999))
{
    Console.WriteLine((num/10) % 10);
} 
    
