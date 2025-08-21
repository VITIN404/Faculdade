//Ver se o número é impar ou par, usando TryParse!
Console.WriteLine("DETECTOR DE IMPAR OU PAR!\nSe você quer saber se um número é impar ou par, entre com um número: ");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    int resultado = numero % 2;
    if(resultado != 0)
    {
        Console.WriteLine("\nO número é ímpar");
    }
    else
    {
        Console.WriteLine("\nO número é par");
    }
}
else
{
    Console.WriteLine("\nInfelizmente você não cumpriu o combinado e crashou o programa!");
}

//Se não quiser comentar uma parte, só deixar acontecer!
Console.WriteLine("\nEspere 5 segundos!");
Thread.Sleep(5000);
Console.Clear();

//Calculadora de Cº para Fº
Console.WriteLine("CONVERSOR DE C° PARA F°!\nEntre com a temperatura em Graus Celsius: ");
string entrada2 = Console.ReadLine();

if (double.TryParse(entrada2, out double temp))
{
    double result = (temp * 1.8d) + 32;
    Console.WriteLine("\nA temperatura em fahrenheit é: " + result + "°F");
}
else
{
    Console.WriteLine("\nInfelizmente você não cumpriu o combinado e crashou o programa!");
}