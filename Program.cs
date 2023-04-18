Домашнее задание 2


// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1
Console.WriteLine ("Введите число трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next (100,1000);
//Console.WriteLine(num);
int c = (num%100)/10;
Console.WriteLine($"Итоговое число {c}");


 
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<99)
{
    Console.WriteLine("Третьей цифры нет");
}
if ((num>99)&&(num<999))
{
    int c = (num%100);
    int b =(c%10);
    Console.WriteLine($"Итоговое число {b}");
}
if ((num>999)&&(num<99999))
{
    int c = (num%1000)/100;
    Console.WriteLine($"Итоговое число {c}");
}



 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("нет");   
}
else if (number==2)
{
     Console.WriteLine("нет"); 
}
else if (number==3)
{
     Console.WriteLine("нет"); 
}
else if (number==4)
{
     Console.WriteLine("нет"); 
}
else if (number==5)
{
     Console.WriteLine("нет"); 
}
else if (number==6)
{
     Console.WriteLine("да"); 
}
else if (number==7)
{
     Console.WriteLine("да"); 
}
else
{
    Console.WriteLine("Нет такого дня недели"); 
};
