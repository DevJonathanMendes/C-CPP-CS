// Abrindo um arquivo para leitura.

#include <stdio.h>
#include <stdlib.h>

int main(void){
    FILE *e;
    e = fopen("entrada.dat", "r");
    if(e == NULL){
        printf("Arquivo nao pode ser aberto.");
        exit(1);
    }
}