﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
string number = Convert.ToInt32(Console.ReadLine()).ToString();
if (number.Length == 3){
    System.Console.WriteLine($"Вторая цифра числа: {number[1]}");
}
else{
    System.Console.WriteLine("Вы ввели неверное число");
}