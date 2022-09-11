void point()
{
    Console.WriteLine("Введите начальную координату первой прямой ");
    decimal b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите начальную координату второй прямой ");
    decimal k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите завершающую координату первой прямой ");
    decimal b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите завершающую координату второй прямой ");
    decimal k2 = Convert.ToInt32(Console.ReadLine());

    decimal x = (b1 - b2) / (k2 - k1);
    decimal y = (k2 * b1 - k1 * b2) / (k2 - k1);

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
point();