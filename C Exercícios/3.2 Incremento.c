/* Exercício 3.2.
 *
 * Seja x=5 e considere a instrução y = x++ + ++x.
 * Quais os valores das variáveis x e y após a execução dessa instrução? Por quê?
 * 
 * Resposta: O valor da variável x vai aumentando.
 * 
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    int x = 5, y;
    y = x++ + ++x;
    printf("VARIAVEL X: %2.d\nVARIAVEL Y: %2.d", x, y);
    getch();
    return 0;
}