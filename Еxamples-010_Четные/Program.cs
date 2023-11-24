using System;

public class Answer {
    // Метод PrintEvenNumbers принимает число number и выводит все чётные числа от 2 до number (включительно)
    static void PrintEvenNumbers(int number) {
        // Используем цикл for для перебора четных чисел от 2 до number
        for (int i = 2; i <= number; i += 2) {
            // Выводим текущее четное число без перевода строки
            Console.Write($"{i}\t");
        }

        // Переход на новую строку после вывода всех четных чисел
        Console.WriteLine();
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        // Проверяем, есть ли аргументы командной строки
        if (args.Length >= 1) {
            // Если есть, преобразуем первый аргумент в число
            number = int.Parse(args[0]);
        } else {
            // Если аргументов нет, используем значение по умолчанию (6)
            number = 6;
        }

        // Не удаляйте строки ниже
        // Вызываем метод PrintEvenNumbers с заданным числом в качестве аргумента
        PrintEvenNumbers(number);
    }
}
