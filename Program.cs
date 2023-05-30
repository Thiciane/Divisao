try
{
    Console.WriteLine("Informe dois números: ");

    int numero1 = Convert.ToInt32(Console.ReadLine());
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int resultado = numero1 / numero2;
    Console.WriteLine($"O resultado é: {resultado}");
}
catch(Exception ex)
{
    Console.WriteLine("ERROR!");
}
Console.ReadKey();