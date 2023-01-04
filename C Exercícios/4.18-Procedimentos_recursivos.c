/* Exercício 4.18.
 *
 * Defina os seguintes procedimentos recursivos:
 * regr(n), que exibe uma contagem regressiva à partir de n.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>

void regr(int n)
{
    if(n == 0) return;
    regr(n - 1);
    printf("%d\n", n);
}

int main(void)
{
    int x = 10;
    regr(x);
}