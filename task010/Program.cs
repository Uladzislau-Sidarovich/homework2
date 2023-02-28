Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string threeNumber = Convert.ToString(number);
if (number >= 100 && number <= 999)
{
    Console.WriteLine("вторая цифра этого числа " + threeNumber[1]);
}
