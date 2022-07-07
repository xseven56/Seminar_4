// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
//Console.Write ("Введите первое целое число:");
//int squareNumber = Convert.ToInt32(Console.ReadLine());
//Console.Write ("Введите второе целое число:");
//int Number = Convert.ToInt32(Console.ReadLine());

//if (squareNumber == Number*Number)
//{
//    Console.WriteLine("Первое число является квардартом второго");
//}
//else 
//{
//    Console.WriteLine("Первое число не является квардартом второго");
//}
//
// Console.Write ("Введите день недели ");
// int dayNumber=Convert.ToInt32(Console.ReadLine());

// if (dayNumber >=1 &&  dayNumber <=7)
// {
//     if(dayNumber==1)
// {
//     Console.WriteLine ("Понедельник");
// }
//     if(dayNumber==2)
// {
//     Console.WriteLine ("Вторник");
// }
//     if(dayNumber==3)
//     {
//         Console.WriteLine ("Среда");
//     }

// }
// else
// {
//     Console.WriteLine ("error 404");
// }

// Console.Write("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int negativen = N * (-1);
// while (negativen <= N)
// {
//     Console.WriteLine(negativen);
//     negativen++;
// }


// Задание №1.1
Console.WriteLine ("Введите первое число ");
int Number1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе число ");
int Number2 = Convert.ToInt32 (Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (Number1<Number2)
{
    Console.WriteLine ("Первое число меньше второго");
}
else
{
    Console.WriteLine ("Оба числа равны");
}

// Задание № 1.2

// Console.WriteLine ("Введите первое число ");
// int Number1 = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите второе число ");
// int Number2 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("Введите третье число");
// int Number3 = Convert.ToInt32 (Console.ReadLine ());
// if (Number1 > Number2 && Number3 < Number1)
// {
//     Console.WriteLine("Первое число " + Number1 + " самое большое");
// }
// else if (Number2>Number1 && Number3<Number2)
// {
//     Console.WriteLine ("второе число " + Number2 + " самое большое");
// }
// else if (Number3>Number1 && Number2<Number3)
// {
//     Console.WriteLine ("третье число " + Number3 + " самое большое");
// }
// else
// {
//     Console.WriteLine ("все числа равны");
// }