/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. */

void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] ArrayOfStrings = new string[size];
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string? element = Convert.ToString(Console.ReadLine());
 ArrayOfStrings[i] = element;
}

string[] FinalArray = new string[size];
int len = 3;
int count = 0;

for (int j = 0; j < size; j++)
{
 if (ArrayOfStrings[j].Length <= len)
    {
 FinalArray[count] = ArrayOfStrings[j];
 count++;
    }
}
Console.WriteLine();
PrintArray(FinalArray);