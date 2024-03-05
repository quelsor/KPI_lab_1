// Знайти середнє арифметичне від'ємних елементів у списку. Замінити на нього мінімальний елемент списку

using System.Globalization;

List<double> list = new List<double>()
{
    1, 5, -8, 10, -45, 0, -306, -78, -1, -4, -409
};

Console.WriteLine("Initial array:");
foreach (int num in list)
{
    Console.Write(num + "\t");
}

double findAverage = FindAverage(list);
ReplaceMinElement(list, findAverage);

double FindAverage(List<double> list)
{
    int count = 0;
    double sum = 0;

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < 0)
        {
            sum += list[i];
            count++;
        }
    }

    double average = sum / count;
    average = Math.Round(average, 2);

    Console.WriteLine($"\n\nAverage: {average}, amount of negative elements: {count}");
    return average;
}

void ReplaceMinElement(List<double> list, double findAverage)
{
    double min = list[0];

    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] < min)
        {
            min = list[i];
        }
    }
    list[list.IndexOf(min)] = findAverage;

    Console.WriteLine($"Minimal element: {min}\n");
    Console.WriteLine("New array: ");

    foreach (double num in list)
    {
        Console.Write(num + "\t");
    }
}
