/* Exercício 5.6.
 *
 * Codifique um programa que indique a quantidade mínima de cédulas equivalente a uma dada quantia em dinheiro.
 * Considere apenas valores inteiros e cédulas de 1, 5, 10, 50 e 100 reais. 
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

int main(void){
    const int nota[2][7] = {{1, 5, 10, 50, 100}}; // LINHA 0: NOTAS E QUANTIA. LINHA 1: QUANTIDADE DE NOTAS NECESSÁRIAS.
    while(nota[0][5] <= 0){
        printf("Quantia: R$ ");
        scanf("%d", &nota[0][5]);
    }
    for(int i = 4; nota[0][5] > 0;){
        nota[1][i] = nota[0][5] >= nota[0][i] ? nota[1][i] + 1 : nota[1][i]; // AUMENTA A QUANTIDADE DE CÉDULAS CASO TRUE.
        nota[0][5] = nota[0][5] >= nota[0][i] ? nota[0][5] - nota[0][i] : nota[0][5]; // SUBTRAI A QUANTIA CASO TRUE.
        i = nota[0][5] < nota[0][i] ? i - 1 : i;
    }
    if(nota[1][4] >= 1)
        nota[1][4] > 1 ? printf("%d notas de R$ %d.00\n", nota[1][4], nota[0][4]) : printf("%d nota  de R$ %d.00\n", nota[1][4], nota[0][4]);
    if(nota[1][3] >= 1)
        nota[1][3] > 1 ? printf("%d notas de R$ %d.00\n", nota[1][3], nota[0][3]) : printf("%d nota  de R$ %d.00\n", nota[1][3], nota[0][3]);
    if(nota[1][2] >= 1)
        nota[1][2] > 1 ? printf("%d notas de R$ %d.00\n", nota[1][2], nota[0][2]) : printf("%d nota  de R$ %d.00\n", nota[1][2], nota[0][2]);
    if(nota[1][1] >= 1)
        nota[1][1] > 1 ? printf("%d notas de R$ %d.00\n", nota[1][1], nota[0][1]) : printf("%d nota  de R$ %d.00\n", nota[1][1], nota[0][1]);       
    if(nota[1][0] >= 1)
        nota[1][0] > 1 ? printf("%d notas de R$ %d.00\n", nota[1][0], nota[0][0]) : printf("%d nota  de R$ %d.00\n", nota[1][0], nota[0][0]);
    return 0;
}