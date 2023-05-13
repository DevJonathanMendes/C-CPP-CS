// Criando uma estrutura apenas nomeada.

#include <stdio.h>

typedef struct{
	int dia;
	int mes;
	int ano;
} DATA;

int main(void){
	DATA nascimento;
	
	nascimento.dia = 18;
	nascimento.mes = 1;
	nascimento.ano = 2001;
	
	printf("Nascimento: %.2d/%.2d/%.4d\n", nascimento.dia, nascimento.mes, nascimento.ano);
}