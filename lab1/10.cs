﻿//Даны три различных целых числа. Определить, какое из них (первое, второе или третье):
//а) самое большое; б) самое маленькое; в) является средним (средним назовем число, которое больше
//наименьшего из данных чисел, но меньше наибольшего).

int[] numbers = new int[3];
Console.WriteLine("Введите 3 целых числа ");

// Читаем три числа с консоли
for (int i = 0; i < 3; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

// Сортируем массив
Array.Sort(numbers);

// Выводим результат
Console.WriteLine($"{numbers[2]} - Наибольшее число, {numbers[1]} - Среднее число, {numbers[0]} - Наименьшее число");