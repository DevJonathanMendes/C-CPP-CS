// Exibindo o conteúdo de um arquivo em vídeo.

#include <stdio.h>
#include <stdlib.h>

int main(void){
    FILE *e;
    char nome[20];
    int c;
    printf("Arquivo: ");
    gets(nome);

    if((e = fopen(nome, "r")) == NULL){
        printf("Arquivo nao pode ser aberto\n");
        exit(1);
    }
    
    while(1){
        c = fgetc(e);
        if(feof(e)){
            break;
        }
        putchar(c);
    }
}