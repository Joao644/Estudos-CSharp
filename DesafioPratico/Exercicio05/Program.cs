namespace Exercicio05;

class Program
{
    static void Main()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        bool placaValida = false;

        if (placa.Length == 7 &&
            char.IsLetter(placa[0]) &&
            char.IsLetter(placa[1]) &&
            char.IsLetter(placa[2]) &&
            char.IsDigit(placa[3]) &&
            char.IsDigit(placa[4]) &&
            char.IsDigit(placa[5]) &&
            char.IsDigit(placa[6]))
        {
            placaValida = true;
        }

        Console.WriteLine(placaValida);
    }
}