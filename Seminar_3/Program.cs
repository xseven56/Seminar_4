//ЛЕЦИЯ 3
// ВИД № 1
// void Method1 ()
// {
//     Console.WriteLine ("Автор....");
// }
// Method1();

// ВИД2
// void Method2(string msg)
// {
//     Console.WriteLine (msg);

// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i<count)
//     {
//         Console.WriteLine (msg);
//         i++;
//     }

// }
// // Method21(msg: "Текст", count: 4);
// Method21(сount:4, msg: "новый текст");

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4 (10, "z");
// Console.WriteLine (res);

// string Method4(int count, string text)
// {
   
//     string result = String.Empty;
//     for (int i = 0; i<count; i++)

//     {
//         result = result + text;
//         }
//     return result;
// }
// string res = Method4 (10, "z");
// Console.WriteLine (res);

// for (int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробеелы заменить черточками, 
// маленьгие буквы "к" заменить на большие "К", а большие "С" на маленькие "с".

// string text = "я думаю, сказал князь, улыбаюсь, - что,"
// + "ежели бы вас послали вместо нашего милого Вицненгероде,"
// +"вы бы взяли приступом согласие прусского короля."
// +"вы так красноречивы. Вы дадите мне чаю?";
// // // string (некоторое коилчество вспомогательно функционала)
// // // string s = "qwerty"
// // // s[3]// r
// string Replace (string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i= 0; i<length; i++)
//     {
//         if (text [i]==oldValue) result = result+ $"{newValue}";
//         else result = result + $"{text[i]}";

//     }
//     return result;
// }
// string newText = Replace (text, ' ','|');

// Console.WriteLine (newText);
// Console.WriteLine();
// newText = Replace (text, 'к','К');
// Console.WriteLine (newText);


// int[]arr = {1,5,4,3,2,6,7,1,1};
// void PrintArray (int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i<count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort (int[] array)
// {
//     for (int i=0; i<array.Length-1; i++)
//     {
//         int minPosition = i;
//         for (int j=i+1; j<=array.Length; j++)
//         {
//             if (array[j]< array [minPosition]);
//         {
//         minPosition=j;
//         }
// }
// int temporary = array[i];
// array[i] = array [minPosition];
// array [minPosition]=temporary;
//     }
// }
// PrintArray (arr);
// SelectionSort(arr);

// 17 Напишите программу, которая принимает
// на вход координаты (x and y), причем x!=0 and y!=0 и
// выдает номер четверти плоскости, в котором находится эта точка.
// int x = Convert.ToInt32 (Console.ReadLine());
// int y = Convert.ToInt32 (Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine (" четверть: 1");
// }

// if (x < 0 && y > 0)
// {
//     Console.WriteLine (" четверть: 2");
// }

// if (x < 0 && y < 0)
// {
//     Console.WriteLine (" четверть: 3");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine (" четверть: 4");
// }


// дача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// int quarterNumber = Convert.ToInt32 (Console.ReadLine());
// if (quarterNumber==1)
// {
//     Console.WriteLine ("X>0 and Y>0");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//d 

// int x1 = Convert.ToInt32 (Console.ReadLine());
// int x2 = Convert.ToInt32 (Console.ReadLine());
// int y1 = Convert.ToInt32 (Console.ReadLine());
// int y2 = Convert.ToInt32 (Console.ReadLine());

// double d = Math.Round (Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1+y2,2)));
// Console.WriteLine ("Расстояние между точками: "+d);


// Задача 22: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// int N = Convert.ToInt32(Console.ReadLine());
// // while (1<=0)
// // {

// // }
// for (int i = 1; i<=N; i++)
// {
//     Console.WriteLine($"Квадрат числа {i} равен {i}*{i}");

// }







// ///////////////////////////////////////////////////////////////////////////////
//  ДОМАШНЕЕ ЗАДАНИЕ К 3 семинару!!!!
// 
/////// 19 //////
// Напишите программу, которая принимает на вход пятизначное число и
//  проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// Console.WriteLine ("Введите пятизначное число ");

// string palindrom = Console.ReadLine();
// int size = palindrom.Length;
// int i = 0;

// if (palindrom.Length==5)//23432
// {
//  if (palindrom[i] == palindrom[size - 1] && palindrom[i + 1] == palindrom[size - 2])
// {
//     Console.WriteLine ("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine ("Число не является палиндромом");
// }
// }
// else 
// {
//     Console.WriteLine ("Число не заданного формата");
// }

// Console.WriteLine ("Thanks");



// ////////////////////////////continuation



// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine ("Введите три координаты первой точки");
int x1 = Convert.ToInt32 (Console.ReadLine());
int y1 = Convert.ToInt32 (Console.ReadLine());
int z1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите три координаты второй точки");
int x2 = Convert.ToInt32 (Console.ReadLine());
int y2 = Convert.ToInt32 (Console.ReadLine());
int z2 = Convert.ToInt32 (Console.ReadLine());

double result = Math.Round (Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
Console.WriteLine ("Расстояние между координатами " + result);
