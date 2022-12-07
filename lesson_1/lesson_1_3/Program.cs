// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
int count = 1;
List<int> array = new List<int>();

Console.WriteLine("Введите " + count + "-е число:");
string str = Console.ReadLine();
if(str == "стоп") 
        
if(int.TryParse(str, out int number)) 
{
array.Add(number);
count++;
}
else
{
Console.WriteLine("Некорректно указано число!\n");
}

Console.WriteLine("Вы создали массив: "); Print(array);

void Print(List<int> array)
{
for(int index = 0; index < count - 1; index++) {
if(index == 0) Console.Write("[" + array[index] + ", ");
else if (index == count - 2) Console.Write(array[index] + "]!");
else Console.Write(array[index] + ", ");
}
}