/* Exercício 3.3.
 *
 * Dado um valor n, exiba uma contagem regressiva.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    for(int n = 10; n >= 0; n--)
    printf("CONTAGEM: %2.2d\n", n);
    
    getch();
    return 0;
}