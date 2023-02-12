// 56.	Написать программу копирования массива

int N;
Console.Write("Введите размер массива [a] : ");
N=Convert.ToInt32(Console.ReadLine());
int[] a;
a=new int[N];
Random random=new Random();
for (int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);
int[]b=new int [a.Length];
Array.Copy (a,b,a.Length);
Console.Write("Массив [a] : ");
for (int i=0;i<a.Length;i++)
    {
        System.Console.Write(a[i]);
    }
System.Console.WriteLine();
Console.Write("Массив [b] : ");
for (int i=0;i<b.Length;i++)
    {
        System.Console.Write(b[i]);
    }