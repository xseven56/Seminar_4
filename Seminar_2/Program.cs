// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next (10,100);// [10,100]
// Console.WriteLine ($"Рандомное число: {number}");
// int digitOne = number / 10; //45-4
// int digitTwo = number % 10; //45-5
// Console.WriteLine ($"Первая цифра нашего числа: {digitOne}");
// Console.WriteLine ($"Вторая цифра нашего числа: {digitTwo}");
// int max = Math.Max(digitOne, digitTwo);
// Console.WriteLine("Самое большое число: "+max);

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next (100,1000);// [10,100]
// Console.WriteLine ($"Рандомное число: {number}");
// int digitOne = number / 100; //45-4
// int digitThree = number % 10; //45-5
// int result = digitOne*10+digitThree;
// Console.WriteLine(""+result);

// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите  первое число: ");
// int firstNumber = Convert.ToInt32 (Console.ReadLine());
// Console.Write("Введите  второе число: ");
// int secondNumber = Convert.ToInt32 (Console.ReadLine());

// int result = (firstNumber % secondNumber);
// if (result ==0)
// {
//     Console.WriteLine ("Кратно");
// }
// else
// {
//     Console.WriteLine ("не кратно" + result);
// }


// 14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

////////////////////////////////////////////////
// 11.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random ().Next (100, 1000);
// Console.WriteLine (number);

// int SearchNumber(int Number)
// {
//     int first = number / 100;
//     int third = number % 10;
//     return first *10 + third;

// }
// Console.WriteLine (SearchNumber(number));
// }
// Console.WriteLine (SearchNumber(number));

// int number = new Random ().Next (100, 1000);
// Console.WriteLine (number);

//     int first = number / 100;
//     int third = number % 10;
//     Console.WriteLine ("Результат " + first + third);

// /////////////////
// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int numberFirst = Convert.ToInt32 (Console.ReadLine());
// int numberSecond = Convert.ToInt32 (Console.ReadLine());
// if (numberFirst % numberSecond == 0)
// {
//     Console.Write (" Числа кратны друг другу");
// }
// else
// {
//     Console.Write ($"Остаток от деления{numberFirst % numberSecond}");
// }

// 14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// bool paritycheck (int number)
// {
//     return (number % 7 == 0 && number % 23==0);
// }
// Console.WriteLine (paritycheck(161));

// Console.WriteLine (number);

// int SearchNumber(int Number)
// {
//     int first = number / 100;
//     int third = number % 10;
//     return first *10 + third;



















// ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 2



// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine ("Введите число ");
// string anyNumber = Console.ReadLine();
// if (anyNumber.Length > 2)
// {
//     Console.WriteLine ("Третья цифра " + anyNumber [2]);
// }

// else 
// {
//     Console.WriteLine ("Третьей цифры нет");
// }

// 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine ("Введите число ");
string anyNumber = Console.ReadLine();
if (anyNumber.Length > 2 && anyNumber.Length < 4)
{
    Console.WriteLine ("Вторая цифра " + anyNumber [1]);
}

else 
{
    Console.WriteLine ("Введенная цифра не соответсвует формату значения");
}
