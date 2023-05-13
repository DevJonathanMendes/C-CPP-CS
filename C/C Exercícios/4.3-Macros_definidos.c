/* Exercício 4.3.
 *
 * Crie um arquivo com as macros definidas no exercício 4.2 e faça um programa que use esse arquivo para testar essas macros.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <ctype.h>
#include "testes.h" // Tem um monte de macros definidas sobre letras minúsculas e maiúsculas.

int main(void)
{
    char x;
    printf("Digite uma letra: ");
    scanf("%c", &x);

    eh_minuscula(x);
    eh_maiuscula(x);
    minuscula(x);
    maiuscula(x);
}