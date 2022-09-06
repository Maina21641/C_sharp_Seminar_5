// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.e.WriteLine("Hello, World!");

int [] InvertArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++){
        arr [i] *= -1;
    }
    return arr;
}
int [] array = new int[]{-4, -8, 8, 2};
foreach (var item in InvertArray(array)){
    Console.WriteLine(item);
}

