// вывести вых если от 1 до 7 вых. день нед.
int number = new Random().Next(1, 8);

Console.WriteLine(number);

if(number < 6)
{
 Console.WriteLine("нет"); 
}
else
{
Console.WriteLine("да");
}
