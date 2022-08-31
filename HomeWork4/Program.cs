// Принимаем число N и выводим все четные числа в диапазоне от 1 до N
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 2; i <= number; i= i+2)
{
    Console.Write(i + ", ");
}
