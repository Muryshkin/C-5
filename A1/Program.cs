// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);


    if (n >= 100 && n <= 999)
    {
        n = n % 2;
        Console.Write($"{n} ");
    }
   
    else 
    {
        Console.WriteLine("Не правельный ввод ");
    }
}
return n;


Console.WriteLine(string.Join(", ", arr));
