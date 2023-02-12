// 54.	С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
System.Console.WriteLine("Введите число N:");
    int N=Convert.ToInt32(Console.ReadLine());
    int f=0;
    int f1=1;
      
    for (int k=0;k<=N-1;k++) 
    {
        System.Console.Write($" {f} ");
        f=f1+f;
        f1=f-f1;
    }

