// Criando um tipo de estrutura anônima para armazenar uma data.
// Do tipo anônima não pode ser referenciado em outras partes do programa.
// Não é possível declarar outras variáveis do mesmo tipo da struct nomeada "hoje".

#include <stdio.h>

// struct sem rótulo.
struct{
	int dia;
	int mes;
	int ano;
} hoje; // Nome da struct cujos membros são: dia, mes e ano.

int main(void){
	// Atribuindo valores para os membros da struct nomeada (variável) "hoje".
	hoje.dia = 18;
    hoje.mes = 1;
    hoje.ano = 2001;
	
    // Prompt para exibir os valores na tela.
    printf("Nascimento: %.2d/%.2d/%.2d\n", hoje.dia, hoje.mes, hoje.ano);
}