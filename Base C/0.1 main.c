#include <stdio.h>

int main(void){
    float nota = 0;

    for(int i = 0, valor = 0; i < 5; i++){
        printf("Nota do aluno %d: ", i+1);
        scanf("%d", &valor);
        nota += valor;
    }
    printf("Nota: %f", nota);

    return 0;
}