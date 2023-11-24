using System;

public class Answer {
    static void PrintEvenNumbers(int number) {
        for (int i = 2; i <= number; i += 2) {
            Console.Write($"{i}\t");
        }
        Console.WriteLine(); // Переход на новую строку после вывода всех четных чисел
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            // Здесь вы можете поменять значения для отправки кода на выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
