Console.WriteLine("Введите любую цифру");
int value = Convert.ToInt32(Console.ReadLine());
for (int power = 0; power <= 32; power++)
Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");