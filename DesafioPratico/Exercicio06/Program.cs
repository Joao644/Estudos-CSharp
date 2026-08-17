namespace Exercicio05;

class Program
{
    static void Main()
    {
        DateTime hoje = DateTime.Now;

        // Formato completo
        Console.WriteLine(hoje.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"));

        // Apenas a data
        Console.WriteLine(hoje.ToString("dd/MM/yyyy"));

        // Apenas a hora
        Console.WriteLine(hoje.ToString("HH:mm:ss"));

        // Data com o mês por extenso
        Console.WriteLine(hoje.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}