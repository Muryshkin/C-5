// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 1001);

if (n == arr[i]%2-1)
{
    n++;
}
else
break;
}
return;
void PrintArray(int[] n)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(n[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}