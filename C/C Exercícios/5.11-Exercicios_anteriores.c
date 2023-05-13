/* Exercício 5.11.
 *
 * Usando as funções desenvolvidas nos exercícios anteriores, altere o programa apresentado de modo que sejam exibidos:
 * temperatura média, a mínima, a máxima e também o histograma de temperaturas.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define dias 7

// Imprime as linhas.
void lin(int l){
    for(int i = 0; i < l; i++){
        printf("#");
    }
}

void histograma(int t[]){
    char dia[dias] = {'S', 'T', 'Q', 'Q', 'S', 'S', 'D'};
    for(int i = 0; i < dias; i++){
        printf("%c: ", dia[i]);
        lin(t[i]);
        printf("\n");
    }
}

void media(int x[]){
    int m = 0;
    for(int i = 0; i < dias; i++){
        m += x[i];
    }
    printf("\nMedia: %d\n", m/dias);
}
void mini(int x[]){
    int min = x[0];
    for(int i = 0; i < dias; i++){
        min = min < x[i] ? min : x[i];
    }
    printf("Minima: %d\n", min);
}

void maxima(int x[])
{
    int maxima = x[0];
    for(int i = 0; i < dias; i++){
        maxima = maxima > x[i] ? maxima : x[i];
    }
    printf("Maxima: %d\n\n", maxima);
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
    media(temperatura);
    mini(temperatura);
    maxima(temperatura);
    histograma(temperatura);
    return 0;
}