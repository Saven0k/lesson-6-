// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите координаты точек в порядке (b1 k1 b2 k2): ");
double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
PointIntersection(array);
void PointIntersection(double[] arra)
{
    double x = (arra[2] - arra[0]) / (arra[1] - arra[3]);
    double first_point = Math.Round((arra[1] * x + arra[0]) , 2);
    double second_point = Math.Round((arra[3] * x + arra[2]) , 2);
    Console.WriteLine($"b1 = {arra[0]}, k1 = {arra[1]}, b2 = {arra[2]}, k2 = {arra[3]} -> ({first_point}; {second_point})");
}

PointIntersection(array);