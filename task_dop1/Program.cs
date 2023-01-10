// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в N-мерном пространстве. Сначала задается N 
//с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число изменерий:");
int N = Convert.ToInt32(Console.ReadLine());


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] A = new int[N];
Console.WriteLine("Координаты точки А:");
FillArray(A);
PrintArray(A);

int[] B = new int[N];
Console.WriteLine("Координаты точки B:");
FillArray(B);
PrintArray(B);
double sum = 0;
int i=0;
while (i<N)
{
sum = sum + Math.Pow((B[i]-A[i]),2);
    i++;
}
double d = Math.Sqrt(sum);
Console.WriteLine($"Расстояние между точками A и B -> {Math.Round(d, 2)}");

//double D = Math.Sqrt(Math.Pow((B[0]-A[0]),2)+Math.Pow((B[1]-A[1]),2)+Math.Pow((B[2}-z1),2));

//Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Math.Round(D, 2)}"); 
