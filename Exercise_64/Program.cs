// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers(int n, int a){
    
    if (Math.Max(n,a) != (Math.Min(n,a))) ShowNumbers(Math.Min(n,a) + 1, Math.Max(n,a));
    Console.Write($"{Math.Min(n,a)} ");
}

ShowNumbers(9,1);






