Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a = " +num1);

Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b = " +num2);

if(num1 > num2)
{
    Console.WriteLine($"{num1} максимальное число");
}
else 
{
    Console.WriteLine($"{num2} максимальное число");
}