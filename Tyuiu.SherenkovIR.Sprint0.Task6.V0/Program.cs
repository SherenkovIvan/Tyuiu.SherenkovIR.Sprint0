using Tyuiu.SherenkovIR.Sprint0.Task6.V0.Lib;

int[] numsArray = new int [] { 1, 2, 3, 4, 5 };
Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numsArray));
Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(numsArray));
Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(numsArray));
Console.ReadKey();

