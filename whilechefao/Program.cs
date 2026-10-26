
/*Exercício 4 (Nível 1 - Laços)
Imagine que você está enfrentando um Chefão.

Crie uma variável int hpChefe = 3; fora do laço.

Escreva um laço while que continue rodando enquanto o hpChefe for maior que 0.

Dentro do laço, retire 1 ponto de vida do chefe (você pode usar hpChefe--; ou hpChefe = hpChefe - 1;).

Logo em seguida, ainda dentro do laço, use o Console.WriteLine() para mostrar a mensagem: "Ataque! HP do chefe agora é: " junto com a variável do HP.
*/


int hpChefe = 3;

while (hpChefe > 0)
{
    hpChefe--;
    Console.WriteLine($"Ataque! HP do chefe agora é: {hpChefe}");

}

