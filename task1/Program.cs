console.Write("Введите целое число: ");
int a = Convert.ToInt32(System.console.ReadLine());
console.Write("Введите еще одно целое число: ");
int b = Convert.ToInt32(System.console.ReadLine());
if (b*b == a) console.WriteLine($"число {a} является квадратом числа {b}");
else console.WriteLine($"число {a} не является квадратом числа {b}");