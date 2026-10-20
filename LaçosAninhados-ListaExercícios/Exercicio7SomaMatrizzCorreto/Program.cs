/*
 7. Somatório Simples de uma Matriz (𝟐 × 𝟐) 
• Enunciado: Dada a matriz int[,] valores = { { 5, 5 }, { 5, 5 } };, calcule e exiba a soma de todos os 
seus elementos usando loops aninhados. 
 */

int[,] valores = { {5, 5} , {5, 5} };
int soma = 0;
    for (int i = 0; i < valores.GetLength(0); i++)
{
    for (int j = 0; j < valores.GetLength(1); j++)
    {

        soma += valores[i, j];
        Console.WriteLine(soma);

    }
}

/* se o consoleWrite fosse dentro do looping interno apareceria: 5, 10, 15 e 20, pois é a soma
 * de cada linha com cada coluna, como são 4 "itens", apareceria a soma de cada um.
 * se ele fosse dentro do looping externo apareceria: 10 e 20, pois é a soma do 5+5 (uma linha toda) e
 * como usamos o += seria tipo (5+5)+(5+5), pegaria o resultado de cada linha completa.
 * Iremos usar fora dos dois loopings pois queremos apenas o resultado final, que é o fim da soma de tudo, 20.
*/

