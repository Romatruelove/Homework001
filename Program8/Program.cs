Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
    
for (int num = 1; num <= N; num++)
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }