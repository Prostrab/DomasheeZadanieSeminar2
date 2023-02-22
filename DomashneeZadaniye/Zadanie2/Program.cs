// Задача 2 "Вывод третьей цифры трехзначного числа или сообщение что ее нет

// Задание 1 Вторая цифры трехзначного числа

   Console.Clear();


Console.WriteLine("Введите трехзначное число");

    int A = Convert.ToInt32(Console.ReadLine());

    if (A > 999) 
Console.WriteLine("Число не соответствует требованию условия");
    if (A < 100)
Console.WriteLine("Третьей цифры нет");
   else
{
  int B = A%10; 
  Console.WriteLine("Третья цифра это: " + B);
}