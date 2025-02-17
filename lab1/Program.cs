int a, b, c;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if (a > b && b > c)
{
    Console.WriteLine($"{a} - Наибольшее число, {b} - Среднее число, {c} - Наименьшее число");
}
else if (a > c && c > b)
{
    Console.WriteLine($"{a} - Наибольшее число, {c} - Среднее число, {b} - Наименьшее число");
}
else if (b > a && a > c)
{
    Console.WriteLine($"{b} - Наибольшее число, {a} - Среднее число, {c} - Наименьшее число");
}
else if (b > c && c > a)
{
    Console.WriteLine($"{b} - Наибольшее число, {c} - Среднее число, {a} - Наименьшее число");
}
else if (c > a && a > b)
{
    Console.WriteLine($"{c} - Наибольшее число, {a} - Среднее число, {b} - Наименьшее число");
}
else if (c > b && b > a)
{
    Console.WriteLine($"{c} - Наибольшее число, {b} - Среднее число, {a} - Наименьшее число");
}
else
{
    Console.WriteLine("Числа равны или введены некорректные значения.");
}