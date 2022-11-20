/* Exercício 4.18(b).
 *
 * Defina os seguintes procedimentos recursivos:
 * b) bin(n), que exibe o número natural n em binário.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

void bin(int n)
{
    if(n >= 1)
    {
        bin(n / 2);
        printf("%d ", n % 2);
    }
}

int main(void)
{
    int x;
    scanf("%d", &x);
    bin(x);
}