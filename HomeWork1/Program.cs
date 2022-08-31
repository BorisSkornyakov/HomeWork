Console.Write("Введите целое число A ");            // Выводим на экран запрос ввести число А
int numberA = Convert.ToInt32(Console.ReadLine());  // Считываем цисло А и преобразуем его в int
Console.Write("Введите целое число B ");            //Выводим на экран запрос ввести число В
int numberB = Convert.ToInt32(Console.ReadLine());  // Считываем цисло B и преобразуем его в int

if (numberA > numberB)                              // Сравниваем числа A и B и выводим максимальное
{
    Console.WriteLine("max = " + numberA);
}
    else if (numberA < numberB)
    {
    Console.WriteLine("max = " + numberB);
    }
        else if (numberA == numberB)                // Если числа A и B равны выводим число А
        {
        Console.WriteLine("max = " + numberA);
        }