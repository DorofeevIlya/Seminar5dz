// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
System.Console.WriteLine("Введите число N:");
    int N=Convert.ToInt32(Console.ReadLine());
    int k=0;
System.Console.WriteLine($"Введите {N} чисел (числа):");
    for (int i=0;i<N;i++)
    {
        int n=Convert.ToInt32(Console.ReadLine());
        if (n>0) k++;
    }
System.Console.WriteLine($"{k} чисел(числа) больше 0");
