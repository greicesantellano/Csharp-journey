/*
 7. Somatório Simples de uma Matriz (𝟐 × 𝟐) 
• Enunciado: Dada a matriz int[,] valores = { { 5, 5 }, { 5, 5 } };, calcule e exiba a soma de todos os 
seus elementos usando loops aninhados. 
 */

int[,] valores = { {5, 5} , {5, 5} };
int soma = 0;
    for (int i = 0; i < valores.GetLength(0); i++)
{
    for (int j = 0; i < valores.GetLength(1); j++)
       soma = j + i;
}

