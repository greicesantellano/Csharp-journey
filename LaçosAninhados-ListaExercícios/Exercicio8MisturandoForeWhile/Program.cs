/*
Enunciado: Faça um loop externo usando while que rode 2 vezes (i de 1 a 2)
e um loop interno usando for que rode 2 vezes (j de 1 a 2),
imprimindo os valores de ambos.
 */

// i 2x (1 a 2) j 2x (1 a 2) console i e j

int i = 1; //inicialização, o i vai começar em 1
    while (i <= 2) //o while vai parar quando o i chegar em 2
{
    for (int j = 1; j <= 2; j++)
        Console.WriteLine($"i = {i}, j = {j}");

    i++;
}            
