/****************************************************************************************
 * Exercício 1.7.
 * 
 * Dada as medidas dos catetos de um triângulo retângulo, informe a medida da hipotenusa.
 * 
 * Jonathan B. Mendes.
 ****************************************************************************************/

#include <stdio.h>
#include <conio.h>
#include <math.h> // Necessária para funções matemáticas avançadas.

int
main(void)
{
    // Para calcular a raiz quadrada, função "sqrt()" da biblioteca "<math.h>".
    // Formula: a² + b² = c²
    
    // Coleta os catetos.
    double c1, c2, h;
    printf("Cateto 1: ");
    scanf("%lf", &c1);
    printf("Cateto 2: ");
    scanf("%lf", &c2);
    
    // Calcula a hipotenusa.
    h = (c1 * c1) + (c2 * c2);
    h = sqrt(h); // Calcula a raiz quadrada.
    printf("Hipotenusa: %.0lf", h);
    getch();
    return 0;
}