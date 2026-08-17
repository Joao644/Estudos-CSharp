namespace Exercicio03;

class Program
{
    static void Main()
    {
        double numero1 = 10;
        double numero2 = 5;

        Console.WriteLine($"Soma: {numero1 + numero2}");
        Console.WriteLine($"Subtração: {numero1 - numero2}");
        Console.WriteLine($"Multiplicação: {numero1 * numero2}");

        if (numero2 == 0)
        {
            Console.WriteLine("numero2 é igual a zero");
        }
        else
        {
            double divisão = numero1 / numero2;
            Console.WriteLine($"Divisão: {divisão}");
        }

        double media = (numero1 + numero2) / 2;
        Console.WriteLine($"Média: {media}");
    }
}