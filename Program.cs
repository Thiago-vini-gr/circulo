using System;

class Program
{
    static void Main()
    {
        // Definir o valor de Pi
        double pi = 3.14159;

        // Leitura do valor do raio
        double raio = double.Parse(Console.ReadLine());

        // Cálculo da área
        double area = pi * raio * raio;

        // Imprimir a área com 4 casas decimais
        Console.WriteLine($"A={area:F4}");
    }
}
