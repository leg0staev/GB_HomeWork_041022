Console.WriteLine("-------------- задача №10 -----------------");

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число и я назову вторую цифру слева этого числа: ");
int num10 = Convert.ToInt32(Console.ReadLine());
//int amount = num10.ToString().Length;
if (num10 > 99 && num10 < 1000){
    int SecondDigit = ( num10 / 10 ) % 10;
    Console.WriteLine($"вторая цифра - {SecondDigit}");
}
else {
    Console.WriteLine("введенное число не трехзначное!");
}

Console.WriteLine("-------------- задача №13 -----------------");

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
*/

Console.WriteLine("Введите число от 100 до 100 000 и я назову третью цифру слева этого числа: ");
int num13 = Convert.ToInt32(Console.ReadLine());

if (num13 > 99 && num13 < 1000){
    int ThirdDigit =  num13 % 10;
    Console.WriteLine($"третья цифра - {ThirdDigit}");
}
else if (num13 > 999 && num13 < 10000){
    int ThirdDigit = ( num13 % 100 ) / 10;
    Console.WriteLine($"третья цифра - {ThirdDigit}");
}
else if (num13 > 9999 && num13 < 100000){
    int ThirdDigit = ( num13 % 1000 ) / 100;
    Console.WriteLine($"третья цифра - {ThirdDigit}");
}
else if (num13 == 100000){
    Console.WriteLine("третья цифра - 0");
}
else if (num13 > 100000){
    Console.WriteLine("ого! Ваше число ооочень большое!");
}
else {
    Console.WriteLine("третей цифры нет");
}

Console.WriteLine("-------------- задача №15 -----------------");

/* Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
Обязательно сделать проверку на ввод чисел меньше 1 и больше 7
*/

Console.WriteLine("Введите номер дня недели и скажу Вам является ли этот день выходным: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber > 0 && DayNumber <= 7){
    if (DayNumber >= 1 && DayNumber <= 5){
        Console.WriteLine("нет. это будний день.");
    }
    else{
        Console.WriteLine("да! это выходной.");
    }
}
else{
    Console.WriteLine("В неделе семь дней. Введите число от 1 до 7.");
}