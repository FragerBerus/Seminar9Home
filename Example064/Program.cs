// Задача 64:
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.Clear();
Console.Write("Введите значение, от которого нужно вывести числа: ");
int minNumber = int.Parse(Console.ReadLine());
Console.Write("Введите значение, до которого нужно вывести числа: ");
int maxNumber = int.Parse(Console.ReadLine());
if (minNumber > 0 && maxNumber > 0 && minNumber <= maxNumber)
{
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();  
    return(start + ", " + PrintNumbers(start + 1, end));    
}
Console.WriteLine(PrintNumbers(minNumber, maxNumber));
}
else
{
    Console.WriteLine("Введен неправильный диапазон натуральных чисел.");
    return;
}