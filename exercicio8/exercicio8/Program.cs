using System;

public class exercicio8
{
    public static void Main(string[] args)
    {
        int nota = 16;

        switch (nota)
        {
            case int n when (nota > 20 || nota < 0):
                Console.WriteLine("Nota inválida");
                break;
            case int n when (nota > 17):
                Console.WriteLine("Excelente");
                break;
            case int n when (nota > 13):
                Console.WriteLine("Bom");
                break;
            case int n when (nota > 9):
                Console.WriteLine("Suficiente");
                break;
            case int n when (nota > 0):
                Console.WriteLine("Insuficiente");
                break;
            default:
                Console.WriteLine("Nota inválida");
                break;
        }

    }
}
