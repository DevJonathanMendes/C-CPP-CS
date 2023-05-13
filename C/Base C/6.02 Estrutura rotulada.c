// Criando um tipo de estrutura rotulada.
// Temos que usar a palavra "struct" precedendo o rótulo.
// [A terceira possibilidade (rotulada e nomeada) não é necessário]

#include <stdio.h>

// struct rotulada como "data".
typedef struct data{
	int dia;
	int mes;
	int ano;
}; // struct não nomeada.

int main(void){
	// Declarando variáveis da struct rotulada como "data". [A palavra "struct" é obrigatório]
	struct data nascimento;
	struct data ontem, amanha;

	// Atribuindo valores para os membros da struct da variável "hoje".
	nascimento.dia = 18;
	nascimento.mes = 1;
	nascimento.ano = 2001;

    // Prompt para exibir os valores na tela.
    printf("Nascimento: %.2d/%.2d/%.4d\n", nascimento.dia, nascimento.mes, nascimento.ano);
}