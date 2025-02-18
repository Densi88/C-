void exercise1()
{
    string kopeykiWord = "";
    string rublesWord = " ";
    Console.WriteLine("Input a count of kopeyki");
    var numberOfKopeyki = int.Parse(Console.ReadLine());
    if (numberOfKopeyki < 0 || numberOfKopeyki > 9999)
    {
        Console.WriteLine("Некоректный ввод");
    }
    else
    {
        int integerRubles = numberOfKopeyki / 100;
        numberOfKopeyki = numberOfKopeyki % 100;
        if (numberOfKopeyki%10==1)
        {
            kopeykiWord = "копейка";
        }
        if(numberOfKopeyki%10>=2 && numberOfKopeyki % 10 <= 4)
        {
            kopeykiWord = "копейки";
        }
        if (numberOfKopeyki%10>=5 && numberOfKopeyki%10<=9 || numberOfKopeyki%10==0)
        {
            kopeykiWord = "копеек";
        }
        if (numberOfKopeyki>=11&& numberOfKopeyki<=20)
        {
            kopeykiWord = "копеек";
        }


        if (integerRubles % 10 == 1)
        {
            rublesWord = "рубль";
        }
        if (integerRubles % 10 >= 2 && integerRubles % 10 <= 4)
        {
            rublesWord = "рубля";
        }
        if (integerRubles % 10 >= 5 && integerRubles % 10 <= 9 || integerRubles % 10 == 0)
        {
            rublesWord = "рублей";
        }
        if (integerRubles >= 11 && integerRubles <= 20)
        {
            rublesWord = "рублей";
        }
        Console.WriteLine(integerRubles + " " + rublesWord + " " + numberOfKopeyki + " " + kopeykiWord);
    }
}
exercise1();
