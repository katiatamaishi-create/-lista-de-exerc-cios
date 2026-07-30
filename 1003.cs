using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int quantidade = 0;
        double soma = 0;

        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor > 0)
            {
                quantidade++;
                soma += valor;
            }
        }

        double media = soma / quantidade;

        Console.WriteLine(quantidade + " valores positivos");
        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
    }
}
