// Задание 1 Вторая цифры трехзначного числа

   Console.Clear();


Console.WriteLine("Введите трехзначное число");

    int A = Convert.ToInt32(Console.ReadLine());

    if (A > 999) 
Console.WriteLine("Число не соответствует требованию условия");
    if (A < 100)
Console.WriteLine("Число не соответствует требованию условия");
   else
{
    int B = (A/100) * 100; int C = A%10; int D = B+C; int F = (A - D)/10;

Console.WriteLine("Второе число это чиcло : " + F);
}


