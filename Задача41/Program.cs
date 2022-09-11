void PositivNumbers()
{
    Console.WriteLine("Введите числа которые хотите видеть в списке(через пробел) ");
    string arrayNumber = Console.ReadLine();
    int[] array = arrayNumber.Split(' ').Select(int.Parse).ToArray();

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
PositivNumbers();