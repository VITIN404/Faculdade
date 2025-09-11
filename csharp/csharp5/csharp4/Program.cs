int quant = 3;
int[] idade = new int[quant];
string[] sexo = new string[quant];
int quant_mulher = 0;
int quant_homem = 0;


for(int i = 0;i < quant; i++)
{
    Console.WriteLine("Quantos anos tem? ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out idade[i]))
    {
        Console.WriteLine("\nQual o seu sexo? (Responda com F ou M!)");
        sexo[i] = Console.ReadLine();
        Console.WriteLine();

        if (sexo[i] != "F" && sexo[i] != "M" && sexo[i] == "f" && sexo[i] == "m")
        {
            Console.WriteLine("\nColoque uma opção válida!\nDADOS RESETADOS!");
            i--;
        }
        else
        {
            if (sexo[i] == "F" || sexo[i] == "f")
            {
                quant_mulher += 1;
            }
            if (sexo[i] == "M" || sexo[i] == "m")
            {
                quant_homem += 1;
            }
        }
    }
    else
    {
        Console.WriteLine("\nColoque um número que remeta a uma idade real!");
        i--;
    }
}

int maior_idade = idade.Max();
Console.WriteLine("\nA pessoa mais velha colocada no sistema tem " + maior_idade + " anos");
Console.WriteLine("Número de mulheres: " + quant_mulher);
Console.WriteLine("Número de homens: " + quant_homem);