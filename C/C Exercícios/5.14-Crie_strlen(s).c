/* Exercício 5.14.
 *
 * Codifique a função strlen(s), que devolve o número de caracteres armazenados na string s.
 * Lembre-se de que o terminador '\0' não faz parte da string e, portanto, não deve ser contado.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define tam 10

int StringTam(char s[]){
    int i = 0;
    while(s[i] != '\0')
    i++;
    return printf("%d", i);
}

int main(void){
    char nome[tam];
    gets(nome);
    StringTam(nome);
}