Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string FiveDigitNumber = Convert.ToString(number);
if (number >= 10000 && number <= 99999)
{
  Console.WriteLine("третья цифра  " + FiveDigitNumber[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
  Console.WriteLine("это не пятизначное число");
}
