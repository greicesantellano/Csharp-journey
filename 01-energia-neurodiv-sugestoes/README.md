# 01 - Energia Neurodiv

## Conceitos praticados

- Console.WriteLine()
- Console.ReadLine()
- int.Parse()
- Variáveis
- if
- else if
- else
- Operadores relacionais (>= <=)
- Operador lógico AND (&&)

**Objetivo:** 

Auxiliar pessoas neurodivergentes a escolherem sua próxima atividade de acordo com o seu nível de energia no momento, lembrando que este software não dita regras, são apenas sugestões baseadas em quem vive a neurodivegência e se sobrecarrega por não respeitar seu nível de energia constantemente.

Como funciona:

1. O programa irá perguntar ao usuário qual seu nível de energia, de 1 a 10 e usando números inteiros, naquele momento
2. O usuário irá inserir um número inteiro de 1 a 10.
3. O programa retornará com a sugestão.

RN →

entre 8-10: Mexer no projeto de C# ou em algo novo.

entre 5-7: Praticar lógica de programação usando jogos.

entre 3-4: Consumir algo do interesse, porém em outra língua.

entre 0-2: Descansar ou dormir. Lembre-se: Descansar é dar à si mesmo condições para que consiga, depois, fazer o que é necessário, evitando sobrecarga.

variável nivelEnergia guarda um número inteiro.

fica algo do tipo (isso é meu pensamento, não é pra ser C# perfeito nem portugol, é GREICEGOL kk)

Console.WriteLine(”Digite o seu nivel de energia atual que te sugiro algo pra fazer:”);

int nivelEnergia = int.Parse(Console.ReadLine()!);

if (nivelEnergia >= 0 && nivelEnergia <= 2)

Console.WriteLine(”Descansa, se possível, durma. Descansar é muito mais sobre respeitar seus limites do que sobre preguiça.”);

else if (nivelEnergia ≥ 3) - acho que aqui tem que ser tipo, nivelEnergia maior ou igual a três, menor que 4, pra falar “entre 3 e 4)…

Console.WriteLine(”Olhe um vídeo, ouça uma música, mas em outra língua!”);

else if (nivelEnergia ≥ 4)

Console.WriteLine(”Jogue algum jogo de programação, indicações: sololearn e Codedex”);

else if (nivelEnergia ≥ 5)

Console.WriteLine(”Crie algo! Mexa no seu projeto, veja vídeo aula, publique no GitHub”);