// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
if (num > 99) 
{
    Console.WriteLine(num.ToString()[2]);
}
