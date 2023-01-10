// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
//оно палиндромом. Через строку решать нельзя.

//14212 -> нет
//12821 -> да
//23432 -> да

int[] array = new int[5];
Console.WriteLine("введите цифру 1 пятизначного числа");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите цифру 2 пятизначного числа");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите цифру 3 пятизначного числа");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите цифру 4 пятизначного числа");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите цифру 5 пятизначного числа");
array[4] = Convert.ToInt32(Console.ReadLine());

if (array[0] == array[4] && array[1] == array[3])
    Console.WriteLine($"{array[0]}{array[1]}{array[2]}{array[3]}{array[4]} => палиндромом");
else
    Console.WriteLine($"{array[0]}{array[1]}{array[2]}{array[3]}{array[4]} => не палиндромом");
