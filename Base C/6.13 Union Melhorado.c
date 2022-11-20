// Union: Tipo mutante melhorada.

#include <stdio.h>

typedef struct{
int etiqueta;
union{
    char  a; // 1
    int   b; // 2
    float c; // 3
} valor;
} mutante;

int main(void){
    mutante x;
    x.etiqueta = 1;
    x.valor.b = 255;
    printf("%d", x.valor.b);
}