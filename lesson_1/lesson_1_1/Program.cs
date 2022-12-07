//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write ("Введите A: ");
int a = int.Parse (Console.ReadLine ()!); 


Console.Write ("Введите B: ");
int b = int.Parse (Console.ReadLine ()!);

int multy = a;

for (int i = 1; i < b; i ++) 
multy = multy*a;

Console.WriteLine($"Число {a} в степени {b} равно {multy}");