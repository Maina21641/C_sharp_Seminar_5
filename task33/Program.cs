// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool Contains (int n, int[] arr){
    // foreach (var item in arr) 
    // {
    //     if (item == n){
    //         return true;
    //     }
    // }
    for (int i = 0; i < arr.Length; i++) // пример с другим методом
    {
        if (arr[i] == n){
            return true;
        }
    }
    return false;
}
Console.WriteLine(Contains(5, new int[]{1, 2, 3, 4}));
Console.WriteLine(Contains(3, new int[]{1, 2, 3, 4}));