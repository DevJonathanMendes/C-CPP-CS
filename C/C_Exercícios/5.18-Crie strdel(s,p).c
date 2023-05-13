/* Exercício 5.18.
 *
 * Codifique a função strdel(s,p), que remove o caracter existente na posição p da string s. Se a posição p não existe em s, nada é feito.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#include <string.h>
#define tam 15

void sdel(char s[], int p){
    for(int i = 0; i < p; i++){
        s[i] = s[i];
    }
    for(int i = p; i < strlen(s); i++){
        s[i] = s[i + 1];
    }
    printf("%s", s);
}

int main(void){
    char nome[tam] = "Jonathan";
    sdel(nome, 3);
}