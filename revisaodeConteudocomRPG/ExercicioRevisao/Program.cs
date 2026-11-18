// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * Declare uma variável para armazenar o preço de um produto e atribua o valor 150.50.

Declare uma variável para a
quantidade comprada e atribua o valor 2.

Declare uma variável chamada 
total e calcule o valor multiplicando o preço pela quantidade.

O cliente resolveu adicionar mais um item. 
Atualize o valor da variável de quantidade (sobrescrevendo-a) e recalcule o total, 
sobrescrevendo também a variável do total.
 
 */

double valorProduto = 150.50;
int quantidadeComprada = 2;

double valorTotal = valorProduto * quantidadeComprada;

Console.WriteLine(valorTotal);

quantidadeComprada = quantidadeComprada +1;

valorTotal = valorProduto * quantidadeComprada;

Console.WriteLine(valorTotal);



