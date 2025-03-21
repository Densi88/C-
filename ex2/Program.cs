﻿using System;

class Program
{
    static void Main()
    {
        Menu.Start();
    }
}

public static class DepositLogic
{
    public static int CalculateIncrease(double deposit, double firstNumber)
    {
        double increase = 0;
        double currentSumm = deposit;
        int monthNumber = 3;

        while (increase <= firstNumber)
        {
            monthNumber = (monthNumber % 12) + 1; // Обновляем месяц, если номер больше 12
            deposit *= 1.02;  // Увеличиваем сумму вклада на 2%
            increase = deposit - currentSumm;  // Вычисляем прирост
            currentSumm = deposit;  // Обновляем текущую сумму
        }

        return monthNumber;
    }

    public static int CalculateMonthsForTarget(double startDeposit, double targetAmount)
    {
        int monthCount = 0;

        while (startDeposit <= targetAmount)
        {
            monthCount++;
            startDeposit *= 1.02;  // Увеличиваем сумму вклада на 2% каждый месяц
        }

        return monthCount;
    }
}

public static class Menu
{
   

    public static void Start()
    {
        double deposit, firstNumber, secondNumber;
        int monthNumber = 3;
        int monthCount = 0;

        // Ввод данных
        do
        {
            Console.WriteLine("Введите сумму вклада");
            deposit = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите первую сумму");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сумму");
            secondNumber = double.Parse(Console.ReadLine());

            if (secondNumber < deposit)
            {
                Console.WriteLine("Неправильный ввод, число должно быть больше депозита");
            }
        } while (firstNumber < deposit && secondNumber < deposit);

        // Расчет, когда прирост станет больше первой суммы
        monthNumber = DepositLogic.CalculateIncrease(deposit, firstNumber);
        DisplayMonth(monthNumber, firstNumber);

        // Расчет количества месяцев, чтобы вклад стал больше второй суммы
        monthCount = DepositLogic.CalculateMonthsForTarget(deposit, secondNumber);
        Console.WriteLine("Количество месяцев, за которое вклад станет больше чем " + secondNumber
            + " - " + monthCount);
    }

    public static string DisplayMonth(int monthNumber, double firstNumber)
    {
        string[] months = new string[]
        {
            "январе", "феврале", "марте", "апреле", "мае", "июне", "июле", "августе", "сентябре",
            "октябре", "ноябре", "декабре"
        };

        Console.WriteLine($"Прирост к вкладу стал больше чем {firstNumber} в {months[monthNumber - 1]}");
        string result = $"Прирост к вкладу стал больше чем {firstNumber} в {months[monthNumber - 1]}";
        return result;
    }
}
