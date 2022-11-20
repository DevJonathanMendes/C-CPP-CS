// Ponteiro para estrutura.

#include <stdio.h>

typedef struct{
    char nome[15];
    int idade;
} pessoa;

int main(void){
    pessoa *p, x = {"Jonathan", 20};
    p = &x;
    printf("%s, %d", (*p).nome, (*p).idade); // Também poderia ser p->nome, p->idade
}
/*
Em geral, ponteiros para estruturas são usados como parâmetros por uma questão
de eficiência. Se uma estrutura é muito grande, a passagem por valor pode
consumir um tempo considerável durante a execução do programa.
*/