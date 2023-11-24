using System;

public class Answer {

    // Введите свое решение ниже
    static int FindMax(int a, int b, int c) {
        // Используем тернарный оператор для нахождения максимального значения
        int maxNumber = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
        return maxNumber;
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        } else {
            // Здесь вы можете поменять значения для отправки кода на выполнение
            a = 5;
            b = 6;
            c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        Console.WriteLine($"{result}");
    }
}
