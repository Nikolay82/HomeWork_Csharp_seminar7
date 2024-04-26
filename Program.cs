
//Задача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"


void PrintNumber(int m, int n) {
    if (m < n) {
        Console.Write(m + " ");
        PrintNumber(m+1, n);
    }
    else if (n < m) {
        Console.Write(n + " ");
        PrintNumber(m, n+1);
    }
    else {
        Console.Write(n + " ");
    }
}

PrintNumber(1, 5);
Console.WriteLine();


//********************************************************************************

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 1, n = 1 -> A(m,n) = 3
//m = 1, n = 3 -> A(m,n) = 5
//m = 1, n = 5 -> A(m,n) = 7
//m = 2, n = 1 -> A(m,n) = 5
//m = 2, n = 3 -> A(m,n) = 9
//m = 2, n = 5 -> A(m,n) = 13
//m = 3, n = 1 -> A(m,n) = 13
//m = 3, n = 3 -> A(m,n) = 61
//m = 3, n = 5 -> A(m,n) = 253

/*
int FunctionAkkerman(int m, int n) {
    if (m == 0) {
        return n+1;
    }
    if (n == 0) {
        return FunctionAkkerman(m-1, 1);
    }
    return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));
}

Console.WriteLine(FunctionAkkerman(1, 1));
*/
//********************************************************************************

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1
/*
void PrintArray(int[] arr, int index) {
    Console.Write(arr[index] + " ");
    if (index > 0) {
        PrintArray(arr, index-1);
    }
}

int[] arr = {8, 1, 2, 5, 0, 10, 34};
PrintArray(arr, arr.Length-1);
Console.WriteLine();
*/
//********************************************************************************


