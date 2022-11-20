/* Exercício 5.22.
 *
 * Complemente o programa do exemplo 5.20 de modo que os nomes lidos sejam exibidos em minúsculas, com inicial maiúscula.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <ctype.h>
#include <string.h>

void main(void)
{
    char nome[2][10];
    for(int i = 0; i < 2; i++)
    {
        printf("Nome[%d]: ", i + 1);
        gets(nome[i]);
    }
    for(int i = 0; i < 2; i++)
    {
        printf("%c", toupper(nome[i][0]));
        for(int j = 1; j < strlen(nome[i]); j++)
        {
            printf("%c", nome[i][j]);
        }
        printf("\n");
    }
}