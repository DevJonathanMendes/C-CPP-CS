/* Exercício 5.17.
 *
 * Codifique a função strpos(s,c), que devolve a posição da primeira ocorrência do caracter c na string s; ou −1, caso ele não ocorra em s.
 *
 * Jonathan B. Mendes.
 */

#include <stdio.h>
#define tam 10

void spos(char s[], char c){
    for(int i = 0; s[i] != '\0'; i++){
        if(s[i] == c)
            printf("Pos %d\n", i + 1);
}
}

int main(void){
    char nome[tam] = "Jonathan";
    spos(nome, 'a');
}