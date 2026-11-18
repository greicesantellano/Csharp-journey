
int pontuacaoJogo = 150;
int dano = 30;

pontuacaoJogo -= dano;

Console.WriteLine($"Pontuação: {pontuacaoJogo}");

int itemDescoberto = 2;

pontuacaoJogo = pontuacaoJogo * itemDescoberto;

Console.WriteLine($"Pontos após item descoberto = {pontuacaoJogo}");


// if e if else

if (pontuacaoJogo >= 200)
{
    Console.WriteLine($"Nível concluído com {pontuacaoJogo} pontos, você é Rank S");
}
else if (pontuacaoJogo >= 150)
{
    Console.WriteLine($"Nível concluído com {pontuacaoJogo} pontos, você é Rank A");
}
else
{
    Console.WriteLine("Você morreu");
}

//while
int vidaJogador = 150;
int danoRecebido = 35;

while (vidaJogador >= 0)
{
    vidaJogador -= danoRecebido;
    Console.WriteLine(vidaJogador);
}
Console.WriteLine($"sua vida chegou em {vidaJogador}, você morreu.");

//while + if

int estamina = 100;
int custoAtaque = 30;

while (estamina >= custoAtaque)
{
    estamina -= custoAtaque;
    Console.WriteLine($"Estaminha restante: {estamina}");
    if (estamina <= 40)
    {
        Console.WriteLine("Sua estamina está baixa!");
    }
}
Console.WriteLine("Você não pode mais atacar!");


//do while

int tentativas = 0;
bool bauAberto = false;

