﻿Console.Clear();
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "эвелина")
{
    Console.WriteLine("УРА, ЭТО ЖЕ Эвелина!!!");
}
else
{
    Console.WriteLine("Добро пожаловать");
    Console.WriteLine(username);
}