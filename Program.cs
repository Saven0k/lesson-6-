// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    }
    Console.Write("]");
    return res;
}
void ReplaceArray(int[] arra){
     Console.Write("  -> [");
    int[] new_my_array = new int[arra.Length];
    for (int i = 0; i < new_my_array.Length; i++){
        new_my_array[i] = arra[i];
        if (new_my_array[i] == new_my_array[new_my_array.Length-1]) Console.Write($"{new_my_array[i]}");
        else Console.Write($" {new_my_array[i]} , ");
    }
    Console.Write("]");
}
int[] array = GetArray(10, -9, 10);
ReplaceArray(array);