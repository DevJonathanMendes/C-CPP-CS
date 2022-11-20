/* Exercício 5.8.
 *
 * Digite as funções apresentadas e teste o funcionamento do programa que resolve o problema das temperaturas acima da média.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define max 5


//Obtém dados via teclado e os armazena no vetor.
void obt(float t[]){
    puts("Informe as temperaturas: ");
    for(int i = 0; i < max; i++){
        printf("%d valor? ", i + 1);
        scanf("%f", &t[i]);
    }
}
// Calcula a média dos elementos armazenados no vetor.
float media(float t[]){
    float s = 0;
    for(int i = 0; i < max; i++)
    s += t[i];
    return s/max;
}
// Conta os dias com temperatura acima da média.
int conta(float t[], float m){
    int i, c = 0;
    for(i = 0; i < max; i++)
    if(t[i] > m)
    c++;
    return c;
}
//Determina os dias da semana com temperatura acima da média.
int main(void){
    float temp[max], m;
    obt(temp);
    m = media(temp);
    printf("Statistics: %d", conta(temp,m));
}