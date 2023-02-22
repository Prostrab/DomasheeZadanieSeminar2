// Задание 3 " Принимает на вход цифру - проверяет , является ли д.н выходным "



Console.WriteLine("Введите число от 1 до 7");
int A = Convert.ToInt32(Console.ReadLine());

if (A == 1)
    Console.WriteLine("Понедельник - не является выходным");
if (A == 2)
    Console.WriteLine("Вторник - не является выходным");
if (A == 3)
    Console.WriteLine("Среда - не является выходным");
if (A == 4)
    Console.WriteLine("Четверг - не является выходным");
if (A == 5)
    Console.WriteLine("Пятница - не является выходным");
if (A == 6)
    Console.WriteLine("Суббота - Выходной день");
if (A == 7)
    Console.WriteLine("Воскресенье - Выходной день");

if (A < 7)
    Console.WriteLine("Число не подходит под условие");

if (A > 7)
Console.WriteLine("Число не подходит под условие");




