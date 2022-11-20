/* Exercício 5.13.
 *
 * Codifique a função strcpy(s,t), que copia o conteúdo da string t para a string s.
 * Essa função é útil quando precisamos realizar atribuição entre strings;
 * por exemplo, para atribuir a constante "teste" a uma string x, basta escrever strcpy(x,"teste").
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define tam 10

char strepy(char s[], char t[]){
    for(int i = 0; i <= tam; i++)
    s[i] = t[i];
    return printf("%s\n", s);
}
int main(void){
    char nome[tam], y[tam];
    gets(nome);
    strepy(y, nome);
}