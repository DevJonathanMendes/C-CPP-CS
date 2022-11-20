/* Exercício 5.21.
 *
 * Codifique um programa para ler uma matriz quadrada de ordem n e exibir apenas os elementos da diagonal principal.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

int main(void)
{
    char matriz[3][3] ={
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}};

    for(int y = 0; y < 1; y++)
    {
        for(int x = 0; x < 1; x++)
        {
            printf("[%d] ", matriz[y][x]);
            for(int j = 1; j < 2; j++)
            {
                printf("\n   [%d]", matriz[j][x+1]);
                for(int k = 2; k < 3; k++)
                {
                    printf("\n      [%d]", matriz[k][x + 2]);
                }
            }
        }
        printf("\n");
    }
}