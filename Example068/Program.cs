// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
Console.Clear();
Console.Write("Введите первое положительное число для вычисления функции Аккермана: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе положительное число для вычисления функции Аккермана: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > 0 && secondNumber > 0)
{
    int FunctionAkkerman(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return FunctionAkkerman(n - 1, 1);
        else
            return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
    }
    Console.WriteLine(FunctionAkkerman(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Введеные числа не соответствуют условию задачи.");
    return;
}