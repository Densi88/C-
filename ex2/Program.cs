double deposit;
double firstNumber;
double secondNumber;
int monthCount = 0;
do
{
    Console.WriteLine("Введите сумму вклада");
    deposit = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите первую сумму");
    firstNumber = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую сумму");
    secondNumber = double.Parse(Console.ReadLine());
    if (firstNumber<deposit||secondNumber<deposit)
    {
        Console.WriteLine("Неправильный ввод, числа должны быть больше депозита");
    }
} while (firstNumber<deposit && secondNumber<deposit);
while (deposit<=firstNumber)
{
    monthCount=monthCount+1;
    deposit = deposit * 1.02;
    
}
Console.WriteLine("Количество месяцев, за которое вклад станет больше чем " + firstNumber
    + " - " + monthCount);
while (deposit<=secondNumber)
{
    monthCount = monthCount + 1;
    deposit = deposit * 1.02;
}
Console.WriteLine("Количество месяцев, за которое вклад станет больше чем " + secondNumber
    + " - " + monthCount);