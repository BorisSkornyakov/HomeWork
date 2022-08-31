// Водим три числа и выводим наибольшее из трех
int[] numbers = new int[3];                             // Иничиализируем массив из 3-х элементов
Console.Write("Введите первое число ");                 // записываем в массив по очереди 3 значения
numbers[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
numbers[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
numbers[2] = Convert.ToInt32(Console.ReadLine());
int max = numbers[0];                                   //Инициализируем переменную max
for (int i = 0; i < 3; i++)                             // Находим максимальное значение массива и записываем его в переменную max
{                             
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine(max);                                 // Выводим в консоль максимальное значение
