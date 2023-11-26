// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 2.2, 0.4, 9.11, 7.2, 78.98 };


double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}

double difference = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
