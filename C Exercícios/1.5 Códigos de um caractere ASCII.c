/*******************************************************************************
 * Exercício 1.5.
 * 
 * Dado um caractere, informe o seu código ASCII em octal, decimal e hexadecimal.
 * 
 * Jonathan B. Mendes.
 *******************************************************************************/

#include <stdio.h>
#include <conio.h>

int
main(void)
{
    // Coleta o caractere.
    char c;
    printf("Informe um caractere: ");
    scanf("%c", &c);
    
    // Imprime os códigos em ASCII.
    printf("\nCaractere: %c\n", c);
    printf("Octal: %o\n", c);
    printf("Decimal: %d\n", (int) c);
    printf("Hexadecimal: %x\n", c);
    getch();
    return 0;
}