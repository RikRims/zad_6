//вывод таблицы умножения
void Table (int n)
{
    for (int i = 0; i <= n; i++)
    {
        Console.Write($"| ");
        for (int j = 0; j <= n; j++)
        {
            if (j == 0) Console.Write("");
            else if (i == 0) Console.Write($"{j}  ");
            if ((j == 0) ^ (i == 0)) Console.Write("");
            else if (i * j < 10) Console.Write(" ");
            if ((i > 0) & (j > 0)) Console.Write($"{i * j} ");
        }
        Console.WriteLine(" ");
    }

    
}

//читай текст ниже
int n;
Console.Write("введите число, до которого выводит таблицу умножения: ");
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Ошибка ввода. Дай число: ");
}

//вызов функции
Table(n);