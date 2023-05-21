// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Здравструйте. программа покажет вам максимальное из трех заданных чисел.");

Console.Write("Введите первое число: ");
int Number_1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите второе число: ");
int Number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int Number_3= Convert.ToInt32(Console.ReadLine());

int max = Number_1;
if (Number_2 > max)
{
max = Number_2;
}
if (Number_3 > max)
{
max = Number_3;
}
Console.WriteLine("Наибольшее из введённых чисел = " + max);
