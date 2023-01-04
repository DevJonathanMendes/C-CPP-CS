/**************************************************************************************
 * Exercício 2.5.
 * 
 * Seja "e" uma variável contendo o número de erros detectados num certo processo.
 * Codifique uma instrução capaz de exibir saídas como:
 * 1 erro detectado.
 * 5 erros detectados.
 * 
 * Operador Condicional:
 * condição ? expressão1 : expressão2;
 * Exemplo: x > 0 ? x : y;
 * 
 * Jonathan B. Mendes.
 **************************************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    int e;
    printf("Quantos erros foram detectados?\n");
    scanf("%d", &e);
    
    if(e == 1)
        printf("%d erro detectado.", e);
    
    else if(e == 0)
        printf("Nenhum erro detectado.");
    
    else
        printf("%d erros detectados.", e);
    
    getch();
    return 0;
}