// Crie dois loops aninhados que rodem de 1 a 3.
// Dentro do loop interno, coloque uma condição: se j = 2, dê um break;.
// Imprima os valores de i e j para observar o comportamento.

for (int i = 1; i<= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        if (j == 2)
            break;
        Console.WriteLine($"valor de i = {i}, valor de j = {j}");
    }
}