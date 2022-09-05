// Возведение числа A в натуральную степень B (от Степана)

int Pow(int num, int rank){
    if (rank ==0){
        return 1;
    }
    int result = 1;
    for (int i = 0; i < rank; i++){
        result *= num;
    }
    return result;
}
System.Console.WriteLine(Pow(2, 3));

// Сумма цифр в числе (от Степана)
int GetSum (int number){
    int sum = 0;
    while (number > 0){
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
System.Console.WriteLine(GetSum(82));

// решение через строку - затратно по ресурсам
int GetSum (string number){
int sum = 0;
for (int i = 0; i < number.Length; i ++){
    // sum += Convert.ToInt32(number[i].ToString()); // 1 вариант
    sum += Convert.ToInt32((number[i] - '0')); // 2 вариант через таблицу аске
}
return sum;
}
System.Console.WriteLine(GetSum("82")); // без ковычек, код ругается "не удается преобразовать из "int" в "string""

// Массив из 8 элементов (от Степана)

int[] GetArray(int size = 8)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = new Random().Next(10);
    }
    return arr;
}
foreach (var item in GetArray()){
System.Console.WriteLine(item);
}