// вывести третью цифру рандомного числа
// в диапазоне от 10 до 100000 или написать, что её нет
int number = new Random().Next(10, 10000);

Console.WriteLine(number);

if(number > 99)
{
 Console.WriteLine("третья цифра " + number % 1000 / 100); 
}
else
{
Console.WriteLine("третьей цифры нет");
}


