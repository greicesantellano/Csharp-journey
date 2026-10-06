using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Bem vindo ao GUIA OTAKU DE EMERGÊNCIA");
Console.WriteLine("O que temos pra hoje?");
Console.WriteLine("1.Preciso de algo que me represente");
Console.WriteLine("2.Quero contemplar a vida");
Console.WriteLine("3.Quero me sentir felizinho vendo coisas fofas");
Console.WriteLine("4.Quero batalhas cheias de emoção");
Console.WriteLine("5.Só quero #pas");
Console.WriteLine("Escolhe uma opção, digite o número e aperta no ENTER: ");

int escolhaUsuario = int.Parse(Console.ReadLine()!);
switch(escolhaUsuario)
{
    case 1:
        Console.WriteLine("Recomendação: Smoking behind the supermarket with you");
        Console.WriteLine("Talvez você não fume,");
        Console.WriteLine("mas com certeza você trabalha demais.");
    break;

    case 2:
        Console.WriteLine("Recomendação: Frieren");
        Console.WriteLine("Quando tudo é pesado,");
        Console.WriteLine(" contemplar nosso próprio universo");
        Console.WriteLine("(e entrar em uma crise existencial de leves)");
        Console.WriteLine("nunca é uma má opção.");
        break;

    case 3:
        Console.WriteLine("Recomendação: Chuunibyou demo koi ga shitai");
        Console.WriteLine("Talvez você apanhe pra encontrar,");
        Console.WriteLine("mas juro que vale a pena.");
        break;

    case 4:
        Console.WriteLine("Recomendação: Demon Slayer");
        Console.WriteLine("Se a galera da Ufotable não dorme,");
        Console.WriteLine("é porque tem um motivo. ");
        break;

    case 5:
        Console.WriteLine("Recomendação: Frieren");
        Console.WriteLine("Às vezes a melhor resposta não é correr.");
        Console.WriteLine("É caminhar um pouco,");
        Console.WriteLine("coletar umas magias aleatórias");
        Console.WriteLine("e manter a calma.");
        break;

    default:
        Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 5.");
        break;
}
