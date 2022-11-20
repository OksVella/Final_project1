// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
string[] array1 = { "Voronezh", "28", "yes", "home", "-1", "333" };
string[] array2 = new string[DefineArraySize()];
FillArray2();
PrintArray2();

int DefineArraySize()
{
    int size = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            size = size + 1;
        }
    }
    return size;
}

void FillArray2()
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index = index + 1;
        }
    }
}

void PrintArray2()
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]);
         if (i < array2.Length-1)
         {
            Console.Write(", ");
         }

    }
}
