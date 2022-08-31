// Определяем является ли введенное число четным
Console.Write("Введите число ");                       // запрашиваем ввод числа
int number = Convert.ToInt32(Console.ReadLine());      // Считываем число
int remains = number % 2;                              //Находим остаток при делении на 2
if(remains > 0)                                        // Если остаток больше 0 - число не четное
{
Console.WriteLine("Число " + number + " не четное");
}
else
{
    Console.WriteLine("Число " + number + " четное");  
}

                                
