
//Enunciado: Crie um programa com dois loops for aninhados que rodem de 1 até 3. Em cada passo,
//imprima o valor das duas variáveis no formato i = [valor], j = [valor].

for (int i = 1; i <= 3; i++)
{
    for (int j = i; j <= i; j++)

        Console.WriteLine($"i = {i}, j = {j}");
}
