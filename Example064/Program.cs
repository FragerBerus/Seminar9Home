// Задача 64:
// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Clear();
Console.Write("Введите начальное значение диапазона: ");
int minMeanin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение диапазона: ");
int maxMeanin = Convert.ToInt32(Console.ReadLine());
if (minMeanin > 0 && maxMeanin > 0)
{
    
}
else
{
    Console.WriteLine("Введенные параметры диапазона не соответствуют условию.");
    return;
}
