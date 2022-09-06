// Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 
//Например в масиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительныъ чисел равна 29, сумма отрицательных - 20

int[] GetArray(int minValue, int maxValue, int size = 12)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
var array = GetArray(-9, 9);
int positiveSum = 0;
int negativeSum = 0;
foreach (var item in array)
{
    if (item < 0){
        negativeSum += item;
    }
    else{
        positiveSum += item;
    }
}
System.Console.WriteLine($"[{string.Join(' ', array)}]");
System.Console.WriteLine(positiveSum);
System.Console.WriteLine(negativeSum);