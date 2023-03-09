// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 8)
{
    if (number > 5)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Неверное число недели");
}