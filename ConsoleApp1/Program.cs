using System;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.Start();
    }
}

public class CurrencyProcessor
{
    // Метод для вычисления формы слова для "копейки"
    public string GetKopeykiWord(int numberOfKopeyki)
    {
        string kopeykiWord = "копеек";

        if (numberOfKopeyki % 10 == 1 && (numberOfKopeyki < 11 || numberOfKopeyki > 20))
        {
            kopeykiWord = "копейка";
        }
        else if (numberOfKopeyki % 10 >= 2 && numberOfKopeyki % 10 <= 4 && (numberOfKopeyki < 10 || numberOfKopeyki > 20))
        {
            kopeykiWord = "копейки";
        }

        return kopeykiWord;
    }

    // Метод для вычисления формы слова для "рублей"
    public string GetRublesWord(int integerRubles)
    {
        string rublesWord = "рублей";

        if (integerRubles % 10 == 1 && (integerRubles < 11 || integerRubles > 20))
        {
            rublesWord = "рубль";
        }
        else if (integerRubles % 10 >= 2 && integerRubles % 10 <= 4 && (integerRubles < 10 || integerRubles > 20))
        {
            rublesWord = "рубля";
        }

        return rublesWord;
    }

    // Метод для разделения числа на рубли и копейки
    public void ProcessCurrency(int numberOfKopeyki)
    {
        if (numberOfKopeyki < 0 || numberOfKopeyki > 9999)
        {
            Console.WriteLine("Некоректный ввод");
            return;
        }

        int integerRubles = numberOfKopeyki / 100;
        numberOfKopeyki = numberOfKopeyki % 100;

        string kopeykiWord = GetKopeykiWord(numberOfKopeyki);
        string rublesWord = GetRublesWord(integerRubles);

        Console.WriteLine($"{integerRubles} {rublesWord} {numberOfKopeyki} {kopeykiWord}");
    }
}

public class Menu
{
    private CurrencyProcessor _currencyProcessor = new CurrencyProcessor();

    public void Start()
    {
        Console.WriteLine("Input a count of kopeyki:");
        int numberOfKopeyki;

        if (int.TryParse(Console.ReadLine(), out numberOfKopeyki))
        {
            _currencyProcessor.ProcessCurrency(numberOfKopeyki);
        }
        else
        {
            Console.WriteLine("Некоректный ввод");
        }
    }
}
