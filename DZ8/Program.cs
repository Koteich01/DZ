// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int res = 1;
while (res < number)
{
    Console.WriteLine(res + 1);
    res+= 2;
}