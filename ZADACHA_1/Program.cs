// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Здравструйте. Эта программа, покажет Вам, какое число большее, а какое меньшее.");

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); 

if (firstNumber > secondNumber) // Равно ли 25 числу 5 в квадрате?
{
    // Да, истина
    Console.WriteLine("Первое число " + firstNumber + " является максимальным по отношению к второму числу " + secondNumber);
}
else // Нет
{
    Console.WriteLine("Первое число " + firstNumber + " НЕ является максимальным по отношению к второму числу " + secondNumber);
}