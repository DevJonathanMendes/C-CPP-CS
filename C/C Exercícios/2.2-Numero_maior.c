/***********************************************************
 * Exercício 2.2.
 * 
 * Dados dois números distintos, informe qual deles é maior.
 * 
 * Jonathan B. Mendes.
 ***********************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Coleta os dois números.
    int a, b;
    printf("Valor de A: ");
    scanf("%d", &a);
    printf("Valor de B: ");
    scanf("%d", &b);
    
    // Checa qual deles é maior ou se são iguais.
    if(a > b)
        printf("A maior que B.");
    
    else if(b > a)
        printf("B maior que A.");
    
    else
        printf("A e B iguais.");
    
    getch();
    return 0;
}