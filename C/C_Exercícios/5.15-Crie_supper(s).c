/* Exercício 5.15.
 *
 * Codifique a função supper(s), que converte a string s em maiúscula.
 * Por exemplo, se x armazena "Teste", após a chamada supper(x), x estará armazenando "TESTE".
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <ctype.h>
#define tam 10

void supper(char s[]){
    for(int i = 0; s[i] != '\0'; i++)
    s[i] = toupper(s[i]);
    return printf("%s", s);
}

int main(void){
    char nome[tam];
    gets(nome);
    supper(nome);
}