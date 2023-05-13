/* Exercício 4.2.
 *
 * Defina as macros descritas a seguir:
 *
 * a) eh_minuscula(c): informa se o caracter c é uma letra minúscula.
 * b) eh_maiuscula(c): informa se o caracter c é uma letra maiúscula.
 * c) minuscula(c): converte a letra c para minúscula.
 * d) maiuscula(c): converte a letra c para maiúscula.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <ctype.h>

#define eh_minuscula(c) if(islower(c)) printf("E minuscula!\n")
#define eh_maiuscula(c) if(isupper(c)) printf("E maiscula!\n")
#define minuscula(c) if(isupper(c)) printf("Letra em minusculo: %c\n", tolower(c))
#define maiuscula(c) if(islower(c)) printf("Letra em maiscula: %c\n", toupper(c))

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