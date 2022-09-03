// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.Write("Введите значение, от которого нужно вывести числа: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение, до которого нужно вывести числа: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
if (minNumber > 0 && maxNumber > 0 && minNumber <= maxNumber)
{
int PrintSumNumbers(int start, int end)
{
    if (start == end) return start;  
    return(start + PrintSumNumbers(start + 1, end));    
}
Console.WriteLine(PrintSumNumbers(minNumber, maxNumber));
}
else
{
    Console.WriteLine("Введен неправильный диапазон натуральных чисел.");
    return;
}