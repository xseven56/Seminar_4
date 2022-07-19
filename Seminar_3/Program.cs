//ЛЕЦИЯ 3
// ВИД № 1
// void Method1 ()
// {
//     Console.WriteLine ("Автор....");
// }
// Method1();

// ВИД2
void Method2(string msg)
{
    Console.WriteLine (msg);

}
// Method2(msg: "Текст сообщения");

void Method2(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine (msg);
        i++;
    }

}
Method21(msg: "Текст", count: 4);
Method21(Count:4, msg);
