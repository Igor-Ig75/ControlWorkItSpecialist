/*Задача 
Написать программу, 
	1. Которая из имеющегося массива строк 
		формирует массив из строк, 
	2. Длина которых меньше либо равна 3 симвала.(<=3)
	3. Первоначальный массив можно вести с клавиатуры, 
		3.1 Либо задать на старте выполнения алгоритма. 
	При решении не рекоминдуется пользоваться коллекциями, 
	Лучше обойтись исключительно массивами.
Пример:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "3456", "-9", "computer science"] -> ["-9"]
["Russia", "Denmark", "Kazan"] -> []*/

Console.Clear();

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine("]");
    Console.WriteLine();
}

void ArrayOfStrings(string[] array1, string[] array2)               
{
    int count = 0;
    
    Console.Write("[ ");
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)                      
            Console.Write(array2[count] = array1[i] + " ");
        count++;                                
    }
    Console.Write("]");
}

string[] arr1 = {"243", "hello", "world", ":-)", "-99", "+"};
string[] arr2 = new string[arr1.Length];

PrintArray(arr1);
ArrayOfStrings(arr1,arr2);


