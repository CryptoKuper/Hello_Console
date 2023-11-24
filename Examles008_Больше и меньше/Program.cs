using System;

public class Answer {
    // Метод CompareNumbers принимает два числа и сравнивает их, выводя соответствующее сообщение
    static void CompareNumbers(int firstNumber, int secondNumber) {
        // Проверяем, равны ли введенные числа
        if (firstNumber == secondNumber) {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }

        // Проверяем, является ли первое число больше второго
        if (firstNumber > secondNumber) {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }

        // Проверяем, является ли первое число меньше второго
        if (firstNumber < secondNumber) {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        // Проверяем, есть ли два аргумента командной строки
        if (args.Length >= 2) {
            // Если есть, преобразуем аргументы в числа
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            // Если аргументов нет, используем значения по умолчанию (5 и 5)
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        // Вызываем метод CompareNumbers с двумя числами в качестве аргументов
        CompareNumbers(firstNumber, secondNumber);
    }
}
