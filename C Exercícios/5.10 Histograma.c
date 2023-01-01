/* Exercício 5.10.
 *
 * Codifique a função histograma(t), que exibe um histograma da variação da temperatura durante a semana.
 * Por exemplo, se as temperaturas em t forem 19, 21, 25, 22, 20, 17 e 15°C
 * a função deverá exibir:
 * D: ----------
 * S: -----------
 * T: -------------
 * Q: -----------
 * Q: ----------
 * S: ---------
 * S: --------
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define dias 7

void lin(int l){
    for(int i = 0; i < l; i++)
        printf("-");
}

void histograma(int t[]){
    char dia[dias] = {'S', 'T', 'Q', 'Q', 'S', 'S', 'D'};
    for(int i = 0; i < dias; i++){
        printf("%c: ", dia[i]);
        lin(t[i]);
        printf("\n");
    }
}

int main(void){
    int temperatura[dias];
    printf("Temperaturas da semana\n");
    for(int i = 0; i < dias; i++)
    {
        printf("Dia %d: ", i + 1);
        scanf("%d", &temperatura[i]);
        if(temperatura[i] > 50 || temperatura[i] <= 0)
            i--;
    }
    histograma(temperatura);
    return 0;
}