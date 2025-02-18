string word;
do
{
    Console.WriteLine("Введите слово из четного количества букв");
    word = Console.ReadLine();
    if (word.Length % 2 != 0)
    {
        Console.WriteLine("Слово должно быть с четным количеством букв!");
    }
} while (word.Length%2!=0);
char[] array= word.ToCharArray();
char current;
for(int i=0; i<array.Length; i = i + 2)
{
    current = array[i];
    array[i] = array[i+1];
    array[i+1] = current;
}
string result=new string(array);
Console.WriteLine(result);