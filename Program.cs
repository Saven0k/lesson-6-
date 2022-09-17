// Задача   40: Напишите программу,которая принимает на вход три числа и проверяет,может ли существовать треугольник с такими сторонами.
Console.Clear();
Console.WriteLine("Введите длинны сторон: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
void if_this_triangle(int[] arra)
{
    if (arra.Length > 3) Console.WriteLine("Вы ввели больше чем 3 числа");
    else
    {
        if (arra[0] + arra[1] <= arra[2] || arra[0] + arra[2] <= arra[1] || arra[1] + arra[2] <= arra[0]) Console.WriteLine($"Треугольника со сторонами {arra[0]}, {arra[1]}, {arra[2]} - не существует");
        else Console.WriteLine($"Треугольника со сторонами {arra[0]}, {arra[1]}, {arra[2]} - существует");
    }

}
if_this_triangle(array);

// int[] vosko = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
