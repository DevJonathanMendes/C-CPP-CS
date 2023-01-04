/* Exercício 3.4.
 *
 * Exiba uma tabela de conversão de polegadas em centímetros, variando as polegadas de 0 a 10 de meio em meio.
 * Dica: 1 polegada = 2,54 cm
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    float cm;
    for(float polegada = 1; polegada <= 10; polegada += 0.5)
    printf("%4.1f POLEGADA = %5.2f cm\n", polegada, cm += 2.54);
    
    getch();
    return 0;
}