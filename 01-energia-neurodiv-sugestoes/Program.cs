namespace _01_energia_neurodiv_sugestoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite aqui qual o seu nível de energia nesse momento, de 0 a 10, sendo 0 muito cansado e 10 com muita energia: ");
            int nivelEnergia = int.Parse(Console.ReadLine()!);
            if (nivelEnergia >= 0 && nivelEnergia <= 2)
            {
                Console.WriteLine("Você está cansado, aproveite para descansar.");
            }
            else if (nivelEnergia >= 3 && nivelEnergia <= 4)
            {
                Console.WriteLine("Você está um pouco cansado, veja algo do seu interesse em outra língua.");
            }
            else if(nivelEnergia >= 5 && nivelEnergia <= 7)
            {
                Console.WriteLine("Você pode praticar lógica de programação através de um jogo.");
            }
            else if(nivelEnergia >= 8 && nivelEnergia <= 10)
            {
                Console.WriteLine("Você está com energia, aproveite para aprender algo novo ou dar um jeito no GitHub e no linkedin");
            }
            else
            {
                Console.WriteLine("Digite um valor entre 0 e 10.");
            }
        }
    }
}
