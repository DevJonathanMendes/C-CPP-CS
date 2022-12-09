/* Exercício 3.6.
 *
 * Dados um número natural n, exiba seu fatorial n!. 
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    int fat, n;
    
    printf("FATORIAL DE: ");
    scanf("%d", &n);
    
    for(fat = 1; n > 1; n = n - 1)
    {
        fat = fat * n;
        printf("FATORIAL: %d\n", fat);
    }
    
    getch();
    return 0;
}