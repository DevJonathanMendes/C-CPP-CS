/*****************************************************************
 * Exercício 2.3.
 * 
 * Dado um ano, informe se ele é ou não bissexto.
 * [Dica: um ano é bissexto se é divisível por 4 mas não por 100]
 * 
 * Jonathan B. Mendes.
 *****************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Coleta o ano.
    int ano;
    printf("Digite um ano: ");
    scanf("%d", &ano);
    
    // Verifica se o ano é bissexto.
    ano = ano % 4;
    if(ano == 0)
        printf("E bissexto!");
    else
        printf("Nao e bissexto!");
    
    getch();
    return 0;
}