Console.Write("Введите целое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(System.Console.ReadLine());
if (b*b == a) Console.WriteLine($"число {a} является квадратом числа {b}");
else Console.WriteLine($"число {a} не является квадратом числа {b}");