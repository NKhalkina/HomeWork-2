/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
if(number < 99 || number >1000)
{
    Console.WriteLine("введите трехзначное число");
    return;
}
else {
    int firstDigit = number % 100;
    int secondDigit = firstDigit / 10;
    Console.WriteLine($"{secondDigit}");
}