
int vidaInimigo = 20;
Console.WriteLine(vidaInimigo);

for (int i = 1; i <= 5; i++)
{
    vidaInimigo -= 10;

    if (vidaInimigo <= 0)
    {
        Console.WriteLine("Inimigo derrotado!");
        break;
    }
    else
    {
        Console.WriteLine("Continue atacando!");
    }
}
Console.WriteLine("Fim da batalha!");
