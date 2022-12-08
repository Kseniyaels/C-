// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру: ");
string day = Console.ReadLine() ?? "";

if (day == "1")
{
    Console.WriteLine("Понедельник.Рабочий день");
}
else if (day == "2")
{
    Console.WriteLine("Вторник.Рабочий день");
}
else if (day == "3")
{
    Console.WriteLine("Среда.Рабочий день");
}
else if (day == "4")
{
    Console.WriteLine("Четверг.Рабочий день");
}
else if (day == "5")
{
    Console.WriteLine("Пятница.Рабочий день");
}
else if (day == "6")
{
    Console.WriteLine("Суббота.Выходной день");
}
else if (day == "7")
{
    Console.WriteLine("Воскресение.Выходной день");
}
