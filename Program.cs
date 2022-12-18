// Написать программу, которая из имеющегося массива строк формирует новый
//массив из строк, длина которых меньше, либо равна 3 символам. 

// метод  кол-во элементов в  буквенном массиве

int CountElementstring (string[] array, int n)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
      {
        if (array[i].Length <= n) count += 1;
      }
   return count;
}

// Метод Создаем новый массив
string[] CreateNewArraystring(int Length)
{
    return new string[Length];
}

// Метод, заполняющий массив элементами определенный длины
string[] FillArray(string[] array, string[] newArray, int n)
{
    for (int i = 0; i < newArray.Length;)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <= n) 
            {
                newArray[i] = array[j];
                i++;
            }
        }
    }
    return newArray;
}

// Метод, печатающий новый массив
string PrintArray(string[] array)
{
    string result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}";
        if (i < array.Length - 1) result += ", ";
    }
    return result + " ]";
}

// Клиентский код
string[] myArray = { "mam", "2", "computer" , "-2", "===", "super star"};
int n = 3;
string[] newArray = CreateNewArraystring(CountElementstring(myArray, n));
Console.WriteLine(PrintArray(FillArray(myArray, newArray, n)));
