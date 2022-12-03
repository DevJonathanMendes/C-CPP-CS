/********************************************************************************************
 * Exercício 1.6.
 * 
 * Dada uma temperatura em graus Fahrenheit, informe o valor correspondente em graus Celsius.
 * 
 * Jonathan B. Mendes.
 ********************************************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Fórmula: C = (F - 32) * (5 / 9)
    
    // Coleta a temperatura.
    float F, C;
    printf("Temperatura em graus Fahrenheit: ");
    scanf("%f", &F);
    
    // Converte Fahrenheit pra Celsius.
    C = (F - 32.0) * (5.0 / 9.0); // Precisa estar em números float para calcular em float.
    printf("Temperatura em graus Celsius: %.0f", C);
    getch();
    return 0;
}