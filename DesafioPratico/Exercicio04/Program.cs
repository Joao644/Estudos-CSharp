namespace Exercicio04;

class Program
{
    static void Main()
    {
        Console.Write("Digite: ");
        string palavra = Console.ReadLine();

        int contador = 0;

        foreach (char caractere in palavra)
        {
            if(!char.IsWhiteSpace(caractere))
            {
                contador++;
            }
        }
        Console.WriteLine($"Quantidade de caracteres: {contador}");
    }
}