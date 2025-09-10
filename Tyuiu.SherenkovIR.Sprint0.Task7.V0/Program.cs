using Tyuiu.SherenkovIR.Sprint0.Task7.V0.Lib;

Console.Title = "Спринт #0| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #0                                        *");
Console.WriteLine("* Тема: Создание итогового решения по спринту      *");
Console.WriteLine("* Задание #7                                       *");
Console.WriteLine("* Вариант #0                                       *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать консольную программу на C#, которая     *");
Console.WriteLine("* суммирует значения двух одинаковых массивов по   *");
Console.WriteLine("* длинне.                                          *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");


// Место решения задания
int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Значение элементов массива №1");
for (int i = 0; i < arrayNums1.Length; i++)
{
    Console.WriteLine(arrayNums1[i] + ", ");
}
Console.WriteLine();

int[] arraysNums2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №2");
for (int i = 0;i < arraysNums2.Length; i++)
{
    Console.WriteLine(arraysNums2[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
if (arrayNums1.Length == arraysNums2.Length)
{
    int[] resultArray = DataService.AdditionArrays(arrayNums1, arraysNums2);

    Console.WriteLine("Сумма элементов массива ровна:");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.WriteLine(resultArray[i] + ", ");
    }
}
else
{
    Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
}
Console.ReadLine();
