using System;

public class exercicio9
{
    public static void Main(string[] args)
    {
        int par = 2;

        for (int contador = 0; contador <= 20; contador++)
        {
            if (par == 1 && contador % 2 == 0)
            {
                Console.WriteLine(contador);
            }
            else if (par == 2 && contador % 2 != 0)
            {
                Console.WriteLine(contador);
            }
            else
            {
                Console.WriteLine("Valor invalido uff");
            }
        }
    }
}