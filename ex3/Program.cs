using System;

class Program
{
    static void Main()
    {
        
        Menu.Start();
    }
}

public static class WordProcessor
{
    // Метод для проверки, является ли длина строки четной
    public static bool IsEvenLength(string word)
    {
        return word.Length % 2 == 0;
    }

    // Метод для перестановки символов попарно
    public static string SwapCharacters(string word)
    {
        char[] array = word.ToCharArray();
        char current;

        for (int i = 0; i < array.Length; i += 2)
        {
            current = array[i];
            array[i] = array[i + 1];
            array[i + 1] = current;
        }

        return new string(array);
    }
}

public static class Menu
{
   
    public static void Start()
    {
        string word;

        // Запрашиваем ввод слова от пользователя, пока не получим четное слово
        do
        {
            Console.WriteLine("Введите слово из четного количества букв:");
            word = Console.ReadLine();

            if (!WordProcessor.IsEvenLength(word))
            {
                Console.WriteLine("Слово должно быть с четным количеством букв!");
            }
        } while (!WordProcessor.IsEvenLength(word));

        // Переставляем буквы в слове попарно
        string result = WordProcessor.SwapCharacters(word);
        Console.WriteLine("Результат: " + result);
    }
}
