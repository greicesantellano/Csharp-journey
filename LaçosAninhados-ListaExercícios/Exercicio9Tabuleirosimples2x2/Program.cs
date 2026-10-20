/* 
9.Tabuleiro de Jogo Simples(𝟐 × 𝟐) 
• Enunciado: Inicialize uma matriz de caracteres char[,] tabuleiro = new char[2, 2]; e preencha todas
as posições com o caractere '.' utilizando loops aninhados, exibindo-a em seguida.   */

char[,] tabuleiro = new char[2, 2];
for (int i = 0; i <= 1; i++) //sempre colocar int.
{
    for (int j = 0; j <= 1; j++)
    {
        tabuleiro[i, j] = '.'; //isso define que os valores de i e de j, todos, serão o valor .

        Console.Write(tabuleiro[i, j] + " "); //isso imprime o valor do tabuleiro, que virou .
    }
    Console.WriteLine(); //isso faz com que fique em forma de quadrado, cada linha em uma linha.
}

