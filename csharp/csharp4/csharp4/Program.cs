while (true)
{
    Console.WriteLine("MENU CONVERSOR DE TEMPERATURA!\n1 - °C -> °F\n2 - °F -> °C\n3 - °K -> °R\n4 - °R ->°K\n5 - °C -> °K\n6 - °F -> °R\nO que você pretende fazer? ");
    int entrada = Convert.ToInt32(Console.ReadLine());

    if (entrada > 0 && entrada < 7)
    {
        switch (entrada)
        {
            case 1:
                Console.WriteLine("\nEntre com a temperatura em Graus Celsius: ");
                double temp = Convert.ToDouble(Console.ReadLine());
                double result = (temp * 1.8d) + 32;
                Console.WriteLine($"\nA temperatura convertida fica em {result}°F\n");
                break;

            case 2:
                Console.WriteLine("\nEntre com a temperatura em Fahrenhent: ");
                double temp2 = Convert.ToDouble(Console.ReadLine());
                double result2 = (temp2 - 32) * (5/9d);
                Console.WriteLine($"\nA temperatura convertida fica em {result2}°C\n");
                break;

            case 3:
                Console.WriteLine("\nEntre com a temperatura em Kelvin: ");
                double temp3 = Convert.ToDouble(Console.ReadLine());
                double result3 = temp3 * 1.8d;
                Console.WriteLine($"\nA temperatura convertida fica em {result3}°R\n");
                break;

            case 4:
                Console.WriteLine("\nEntre com a temperatura em Rankine: ");
                double temp4 = Convert.ToDouble(Console.ReadLine());
                double result4 = temp4 / 1.8d;
                Console.WriteLine($"\nA temperatura convertida fica em {result4}°K\n");
                break;

            case 5:
                Console.WriteLine("\nEntre com a temperatura em Graus Celsius: ");
                double temp5 = Convert.ToDouble(Console.ReadLine());
                double result5 = temp5 + 273.15d; 
                Console.WriteLine($"\nA temperatura convertida fica em {result5}°K\n");
                break;

            case 6:
                Console.WriteLine("\nEntre com a temperatura em Fahrenhent: ");
                double temp6 = Convert.ToDouble(Console.ReadLine());
                double result6 = temp6 + 459.67d;
                Console.WriteLine($"\nA temperatura convertida fica em {result6}°R\n");
                break;
        }
    }
    else
    {
        Console.WriteLine("\nVocê não cumpriu os requisitos!\n");
        break;
    }
}