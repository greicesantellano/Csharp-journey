namespace Execicio2_quadradoAsteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Quadrado de Asteriscos (3 × 3)
            • Enunciado: Desenhe um quadrado preenchido de 3 × 3 asteriscos (*) no console utilizando loops
            aninhados.
             */

            for(int i = 1; i <= 3; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine("*");
            }

        }
    }
}
