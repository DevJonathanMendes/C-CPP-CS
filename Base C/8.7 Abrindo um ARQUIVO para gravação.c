// Abrindo um arquivo para gravação.

#include <stdio.h>
#include <stdlib.h>

int main(void){
    FILE *s;
    if((s = fopen("saida.dat", "w")) == NULL){
        printf("Arquivo nao pode ser aberto.");
        exit(1);
    }
}